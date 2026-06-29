# Virtual Tour Perpustakaan IPB University — WebGL

Branch ini berisi hasil build WebGL dari project Virtual Tour Perpustakaan IPB University. Aplikasi dijalankan melalui browser menggunakan Firebase Local Emulator Suite.

> Branch ini hanya berisi hasil build WebGL dan tidak dibuka menggunakan Unity Editor.  
> Source project Unity tersedia pada branch `code-untuk-unity`.

## Persyaratan

Sebelum menjalankan aplikasi, pastikan perangkat sudah memiliki:

- Git
- Git Large File Storage (Git LFS)
- Node.js versi 18 atau lebih baru
- Firebase CLI
- Browser modern, seperti Google Chrome, Microsoft Edge, atau Mozilla Firefox
- Koneksi internet saat pertama kali mengunduh repository dan file Git LFS

## Cara Menjalankan Aplikasi

### 1. Instal Git LFS

Pastikan Git LFS sudah terpasang pada perangkat.

Setelah terpasang, buka Command Prompt, PowerShell, Git Bash, atau terminal, kemudian jalankan:

```bash
git lfs install
```

Perintah ini cukup dilakukan satu kali pada perangkat.

### 2. Instal Firebase CLI

Firebase CLI dipasang menggunakan npm yang tersedia setelah Node.js diinstal.

Jalankan:

```bash
npm install -g firebase-tools
```

Periksa apakah Firebase CLI berhasil dipasang:

```bash
firebase --version
```

Jika nomor versi Firebase CLI muncul, instalasi sudah berhasil.

### 3. Clone Repository

Jalankan perintah berikut untuk mengunduh branch hasil build WebGL:

```bash
git clone -b code-setelah-build-WebGL --single-branch https://github.com/farisambar/Virtual-Tour-Perpustakaan-IPB-University.git
```

Masuk ke folder repository:

```bash
cd Virtual-Tour-Perpustakaan-IPB-University
```

### 4. Unduh File Git LFS

Pastikan seluruh file build berukuran besar sudah terunduh:

```bash
git lfs pull
```

Tunggu sampai proses pengunduhan selesai.

### 5. Periksa Struktur Folder

Pastikan terminal berada pada folder utama repository yang berisi:

```text
Build
assets
.firebaserc
firebase.json
index.html
style.css
```

Firebase Emulator harus dijalankan dari folder yang memiliki file `firebase.json`.

### 6. Jalankan Firebase Emulator

Jalankan perintah:

```bash
firebase emulators:start --only hosting
```

Tunggu sampai terminal menampilkan bahwa Firebase Hosting Emulator sudah berjalan.

Terminal akan menampilkan alamat lokal, biasanya:

```text
http://127.0.0.1:5000
```

atau:

```text
http://localhost:5000
```

### 7. Buka Aplikasi

Buka alamat yang ditampilkan pada terminal menggunakan browser.

Contoh:

```text
http://127.0.0.1:5000
```

Tunggu sampai file Unity WebGL dan seluruh aset panorama selesai dimuat. Proses pertama dapat memerlukan waktu cukup lama karena ukuran file build cukup besar.

## Kontrol Aplikasi

```text
Mouse          : Menggerakkan sudut pandang kamera
Panah Atas     : Memilih atau berpindah ke arah depan
Panah Bawah    : Memilih atau berpindah ke arah belakang
Panah Kiri     : Memilih atau berpindah ke arah kiri
Panah Kanan    : Memilih atau berpindah ke arah kanan
```

Pilihan arah navigasi dapat berbeda pada setiap lokasi virtual tour.

## Menghentikan Firebase Emulator

Kembali ke terminal yang menjalankan Firebase Emulator, kemudian tekan:

```text
Ctrl + C
```

Jika muncul pertanyaan untuk menghentikan proses, konfirmasi dengan menekan:

```text
Y
```

## Mengatasi Masalah

### Perintah `firebase` Tidak Dikenali

Pastikan Firebase CLI sudah dipasang:

```bash
npm install -g firebase-tools
```

Setelah instalasi, tutup terminal dan buka kembali, kemudian periksa:

```bash
firebase --version
```

### Perintah `git lfs` Tidak Dikenali

Pastikan Git LFS sudah terpasang, kemudian jalankan:

```bash
git lfs install
```

### File Build Tidak Terunduh dengan Benar

Jalankan:

```bash
git lfs pull
```

File Git LFS yang belum terunduh dapat menyebabkan aplikasi gagal dimuat.

### File `firebase.json` Tidak Ditemukan

Pastikan terminal berada di folder utama repository:

```bash
cd Virtual-Tour-Perpustakaan-IPB-University
```

Kemudian jalankan kembali:

```bash
firebase emulators:start --only hosting
```

### Aplikasi Menampilkan Halaman Kosong atau Gagal Dimuat

Pastikan:

1. Seluruh file Git LFS sudah diunduh.
2. Folder `Build` tidak dihapus atau dipindahkan.
3. Firebase Emulator dijalankan dari folder utama repository.
4. Aplikasi dibuka melalui alamat yang diberikan Firebase Emulator.
5. Terminal Firebase Emulator tetap terbuka selama aplikasi digunakan.

Jalankan kembali:

```bash
git lfs pull
firebase emulators:start --only hosting
```

### Port Firebase Emulator Sedang Digunakan

Hentikan Firebase Emulator atau aplikasi lain yang menggunakan port tersebut, kemudian jalankan kembali:

```bash
firebase emulators:start --only hosting
```

## Ringkasan

```text
Instal Git dan Git LFS
→ Instal Node.js
→ Instal Firebase CLI
→ Clone branch code-setelah-build-WebGL
→ Jalankan git lfs pull
→ Jalankan firebase emulators:start --only hosting
→ Buka alamat lokal yang muncul pada terminal
```

## Source Project Unity

Untuk membuka dan mengembangkan project menggunakan Unity Editor, gunakan branch:

```text
code-untuk-unity
```

Branch `code-setelah-build-WebGL` digunakan untuk menjalankan hasil build WebGL melalui browser.
