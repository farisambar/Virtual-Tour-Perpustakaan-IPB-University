# Menjalankan dan Hosting Project Unity WebGL

Dokumen ini menjelaskan cara menjalankan hasil build Unity WebGL secara lokal dan melakukan deployment ke Firebase Hosting.

## Prasyarat

Pastikan perangkat sudah memiliki:

- Browser modern seperti Google Chrome, Microsoft Edge, atau Firefox.
- Antigravity IDE atau editor berbasis Visual Studio Code.
- Extension Live Server.
- Node.js dan npm untuk deployment Firebase.
- Firebase CLI untuk deployment Firebase Hosting.

---

# 1. Menjalankan Project secara Lokal

## 1.1 Clone atau Download Repository

Clone repository menggunakan Git:

```bash
git clone <URL_REPOSITORY>
```

Masuk ke folder repository:

```bash
cd <NAMA_FOLDER_REPOSITORY>
```

Repository juga dapat diunduh melalui tombol **Code → Download ZIP**, kemudian ekstrak file ZIP tersebut.

## 1.2 Temukan Folder Hasil Build WebGL

Cari folder yang berisi struktur berikut:

```text
WebGL_Build/
├── Build/
├── TemplateData/
├── index.html
└── StreamingAssets/
```

Folder `StreamingAssets` mungkin tidak tersedia jika project tidak menggunakannya.

File utama yang akan dijalankan adalah:

```text
index.html
```

## 1.3 Buka Folder di Antigravity IDE

Pada Antigravity IDE, pilih:

```text
File
→ Open Folder
```

Buka folder hasil build WebGL yang berisi file `index.html`.

Jangan hanya membuka file `index.html`. Buka seluruh folder build agar semua file `.wasm`, `.data`, dan `.js` dapat terbaca dengan benar.

## 1.4 Instal Extension Live Server

Buka menu **Extensions**, kemudian cari:

```text
Live Server
```

Instal extension tersebut dan lakukan reload Antigravity IDE jika diminta.

## 1.5 Jalankan dengan Live Server

Pada panel Explorer:

1. Klik kanan file `index.html`.
2. Pilih **Open with Live Server**.

Browser akan terbuka pada alamat lokal seperti:

```text
http://127.0.0.1:5500/index.html
```

Project Unity WebGL sekarang dapat dijalankan melalui browser.

## 1.6 Jangan Membuka index.html secara Langsung

Jangan membuka `index.html` dengan klik dua kali dari File Explorer.

Cara tersebut akan menghasilkan alamat seperti:

```text
file:///C:/...
```

Unity WebGL perlu dijalankan melalui server HTTP agar browser dapat memuat file build seperti:

```text
.wasm
.data
.js
```

Gunakan Live Server atau server lokal lainnya.

## 1.7 Mengatasi Error WebAssembly

Apabila muncul error seperti:

```text
WebAssembly streaming compilation failed
```

atau file build memiliki ekstensi:

```text
.wasm.br
.data.br
.framework.js.br
```

build kemungkinan menggunakan kompresi Brotli.

Untuk penggunaan Live Server, buka Unity dan atur:

```text
Edit
→ Project Settings
→ Player
→ WebGL
→ Publishing Settings
→ Compression Format = Disabled
```

Setelah itu, lakukan build ulang WebGL.

---

# 2. Hosting ke Firebase

Setiap pengguna harus menggunakan akun Firebase dan Firebase Project miliknya sendiri.

## 2.1 Instal Node.js

Periksa apakah Node.js dan npm sudah tersedia:

```bash
node -v
npm -v
```

Jika nomor versi muncul, Node.js dan npm sudah terpasang.

Jika belum, instal Node.js terlebih dahulu.

## 2.2 Instal Firebase CLI

Jalankan:

```bash
npm install -g firebase-tools
```

Periksa instalasinya:

```bash
firebase --version
```

Jika nomor versi Firebase CLI muncul, instalasi berhasil.

## 2.3 Login ke Firebase

Jalankan:

```bash
firebase login
```

Browser akan terbuka untuk proses login.

Gunakan akun Firebase masing-masing.

Setelah login berhasil, periksa daftar project:

```bash
firebase projects:list
```

## 2.4 Buat Firebase Project

Buka Firebase Console, kemudian:

1. Pilih **Add project**.
2. Masukkan nama project.
3. Selesaikan proses pembuatan project.
4. Catat bagian **Project ID**.

Contoh Project ID:

```text
nama-project-webgl
```

Project ID akan digunakan saat deployment.

## 2.5 Masuk ke Folder Build WebGL

Buka terminal pada folder yang berisi `index.html`.

Contoh struktur folder:

```text
WebGL_Build/
├── Build/
├── TemplateData/
├── index.html
└── StreamingAssets/
```

Masuk ke folder build:

```bash
cd WebGL_Build
```

Pastikan terminal berada di folder yang sama dengan file `index.html`.

## 2.6 Inisialisasi Firebase Hosting

Jalankan:

```bash
firebase init hosting
```

Jawab pertanyaan Firebase CLI sebagai berikut.

### Pilih Firebase Project

Pilih:

```text
Use an existing project
```

Kemudian pilih Firebase Project yang sudah dibuat.

### Public Directory

Ketika muncul:

```text
What do you want to use as your public directory?
```

Masukkan:

```text
.
```

Tanda titik berarti folder yang sedang dibuka akan digunakan sebagai folder publik.

### Single-Page Application

Ketika muncul:

```text
Configure as a single-page app?
```

Pilih:

```text
No
```

### GitHub Deployment

Ketika muncul:

```text
Set up automatic builds and deploys with GitHub?
```

Pilih:

```text
No
```

### Overwrite index.html

Apabila muncul:

```text
File ./index.html already exists. Overwrite?
```

Pilih:

```text
No
```

Jangan menimpa `index.html` karena file tersebut merupakan halaman utama hasil build Unity WebGL.

## 2.7 Periksa Konfigurasi Firebase

Setelah inisialisasi, Firebase akan membuat file:

```text
firebase.json
.firebaserc
```

Isi dasar `firebase.json` dapat terlihat seperti berikut:

```json
{
  "hosting": {
    "public": ".",
    "ignore": [
      "firebase.json",
      "**/.*",
      "**/node_modules/**"
    ]
  }
}
```

Pastikan nilai `public` adalah:

```json
"public": "."
```

## 2.8 Jalankan Firebase secara Lokal

Sebelum melakukan deployment, project dapat diuji menggunakan Firebase Local Server:

```bash
firebase serve --only hosting
```

Biasanya project dapat dibuka melalui:

```text
http://localhost:5000
```

Untuk menghentikan server, tekan:

```text
Ctrl + C
```

## 2.9 Deploy ke Firebase Hosting

Jalankan:

```bash
firebase deploy --only hosting --project <FIREBASE_PROJECT_ID>
```

Ganti:

```text
<FIREBASE_PROJECT_ID>
```

dengan Project ID Firebase masing-masing.

Contoh:

```bash
firebase deploy --only hosting --project nama-project-webgl
```

Tunggu sampai muncul:

```text
Deploy complete!
```

Firebase akan menampilkan alamat website seperti:

```text
https://nama-project-webgl.web.app
```

---

# 3. Memperbarui Website

Jika terdapat perubahan pada project Unity:

1. Simpan perubahan di Unity.
2. Lakukan build ulang WebGL.
3. Simpan hasil build ke folder yang sama.
4. Pastikan file `firebase.json` dan `.firebaserc` tidak terhapus.
5. Jalankan project secara lokal untuk melakukan pengecekan.
6. Deploy ulang dengan perintah:

```bash
firebase deploy --only hosting --project <FIREBASE_PROJECT_ID>
```

Tidak perlu menjalankan kembali:

```bash
firebase init hosting
```

selama file konfigurasi Firebase masih tersedia.

---

# 4. Perintah Penting

## Menjalankan dengan Live Server

```text
Klik kanan index.html
→ Open with Live Server
```

## Menjalankan Firebase secara Lokal

```bash
firebase serve --only hosting
```

## Melihat Project Firebase

```bash
firebase projects:list
```

## Melihat Akun Firebase yang Sedang Login

```bash
firebase login:list
```

## Login Ulang

```bash
firebase logout
firebase login
```

## Deployment

```bash
firebase deploy --only hosting --project <FIREBASE_PROJECT_ID>
```

---

# 5. Alur Singkat

```text
Clone atau download repository
→ Buka folder hasil build WebGL
→ Jalankan index.html menggunakan Live Server
→ Periksa seluruh fitur
→ Buat Firebase Project
→ Jalankan firebase init hosting
→ Jalankan firebase serve untuk pengujian
→ Jalankan firebase deploy
→ Buka Hosting URL
```

---

# 6. Troubleshooting

## Live Server Tidak Muncul

Pastikan:

1. Extension Live Server sudah terpasang.
2. Antigravity IDE sudah di-reload.
3. Folder yang dibuka adalah folder yang berisi `index.html`.
4. File `index.html` diklik kanan dari panel Explorer.

## Error WebAssembly Streaming Compilation Failed

Buka Unity dan ubah:

```text
Edit
→ Project Settings
→ Player
→ WebGL
→ Publishing Settings
→ Compression Format = Disabled
```

Kemudian lakukan build ulang WebGL.

## Halaman Firebase Welcome Muncul

Hal ini biasanya terjadi karena `index.html` hasil build Unity tertimpa saat menjalankan `firebase init hosting`.

Solusi:

1. Build ulang Unity WebGL.
2. Pastikan `index.html` merupakan file hasil build Unity.
3. Jangan memilih `Yes` pada pertanyaan overwrite `index.html`.
4. Jalankan deployment kembali:

```bash
firebase deploy --only hosting --project <FIREBASE_PROJECT_ID>
```

## Website Masih Menampilkan Versi Lama

Lakukan hard refresh:

```text
Ctrl + F5
```

Website juga dapat diperiksa melalui mode Incognito.

## Project Firebase Tidak Ditemukan

Periksa daftar project:

```bash
firebase projects:list
```

Pastikan Project ID yang digunakan benar:

```bash
firebase deploy --only hosting --project <FIREBASE_PROJECT_ID>
```

## Firebase CLI Tidak Dikenali

Instal ulang Firebase CLI:

```bash
npm install -g firebase-tools
```

Kemudian tutup dan buka kembali terminal.

Periksa kembali:

```bash
firebase --version
```
