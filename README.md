# Virtual Tour Perpustakaan IPB University

Project ini merupakan aplikasi virtual tour Perpustakaan IPB University berbasis Unity dengan tampilan foto panorama 360°.

## Persyaratan

Sebelum menjalankan project, pastikan perangkat sudah memiliki:

- Git
- Unity Hub
- Unity Editor **2022.3.13f1**
- Koneksi internet untuk mengunduh package Unity
- Ruang penyimpanan kosong yang cukup untuk proses import aset

Disarankan menggunakan Unity Editor **2022.3.13f1** agar scene, package, script, dan konfigurasi project tetap kompatibel.

## Cara Menjalankan Project di Unity

### 1. Clone Repository

Buka Command Prompt, PowerShell, Git Bash, atau terminal, kemudian jalankan:

```bash
git clone -b code-untuk-unity https://github.com/farisambar/Virtual-Tour-Perpustakaan-IPB-University.git
```

Setelah proses clone selesai, masuk ke folder project:

```bash
cd Virtual-Tour-Perpustakaan-IPB-University
```

Project juga dapat diunduh tanpa Git melalui GitHub:

```text
Code
→ Download ZIP
→ Extract file ZIP
```

Pastikan repository atau file ZIP diunduh dari branch:

```text
code-untuk-unity
```

### 2. Instal Unity Editor

1. Buka Unity Hub.
2. Masuk ke menu `Installs`.
3. Klik `Install Editor`.
4. Instal Unity Editor versi:

```text
2022.3.13f1
```

5. Tunggu proses instalasi sampai selesai.

### 3. Tambahkan Project ke Unity Hub

1. Buka Unity Hub.
2. Masuk ke menu `Projects`.
3. Klik `Add`.
4. Pilih `Add project from disk`.
5. Pilih folder utama project:

```text
Virtual-Tour-Perpustakaan-IPB-University
```

Pastikan folder yang dipilih berisi:

```text
Assets
Packages
ProjectSettings
```

Jangan memilih folder `Assets` saja.

### 4. Buka Project

1. Pada Unity Hub, pilih project yang sudah ditambahkan.
2. Pastikan project dibuka menggunakan:

```text
Unity 2022.3.13f1
```

3. Tunggu Unity menyelesaikan proses import aset, instalasi package, dan kompilasi script.

Saat pertama kali dibuka, proses ini dapat memerlukan waktu cukup lama karena project memiliki banyak aset foto panorama 360°.

Jangan menutup Unity selama proses import masih berjalan.

### 5. Buka Scene Utama

Setelah project selesai dimuat:

1. Pada panel `Project`, buka folder:

```text
Assets/Scenes
```

2. Cari file scene utama yang memiliki ekstensi:

```text
.unity
```

3. Klik dua kali file scene tersebut.
4. Tunggu sampai seluruh objek muncul pada panel `Hierarchy` dan `Scene`.

Pastikan scene utama sudah terbuka sebelum menjalankan project.

### 6. Jalankan Project

1. Periksa tab `Console`.
2. Pastikan tidak terdapat error berwarna merah.
3. Klik tombol `Play` di bagian atas Unity Editor.
4. Tunggu sampai aplikasi tampil pada tab `Game`.
5. Klik pada area `Game` agar input keyboard dan mouse terbaca.

## Kontrol Aplikasi

```text
Mouse          : Menggerakkan sudut pandang kamera
Panah Atas     : Berpindah atau memilih arah depan
Panah Bawah    : Berpindah atau memilih arah belakang
Panah Kiri     : Berpindah atau memilih arah kiri
Panah Kanan    : Berpindah atau memilih arah kanan
```

Pilihan arah navigasi dapat berbeda pada setiap lokasi virtual tour.

## Menghentikan Project

Untuk menghentikan aplikasi:

1. Klik kembali tombol `Play`.
2. Tunggu sampai Unity keluar dari Play Mode.

Perubahan yang dilakukan ketika Play Mode aktif tidak akan tersimpan secara permanen.

## Mengatasi Masalah

### Project tidak muncul di Unity Hub

Pastikan folder yang dipilih adalah folder utama yang berisi:

```text
Assets
Packages
ProjectSettings
```

### Versi Unity tidak sesuai

Gunakan Unity Editor:

```text
2022.3.13f1
```

Versi Unity yang berbeda dapat menyebabkan perubahan package, material, scene, atau konfigurasi project.

### Package masih diunduh

Pastikan perangkat terhubung ke internet dan tunggu sampai Unity Package Manager selesai mengunduh seluruh package.

Package dapat diperiksa melalui:

```text
Window
→ Package Manager
```

### Scene tidak tampil ketika Play

Pastikan scene utama dari folder berikut sudah dibuka:

```text
Assets/Scenes
```

### Terdapat error pada Console

Buka menu:

```text
Window
→ General
→ Console
```

Tunggu proses kompilasi selesai dan periksa pesan error berwarna merah.

## Ringkasan

```text
Install Git dan Unity Hub
→ Install Unity 2022.3.13f1
→ Clone branch code-untuk-unity
→ Add project from disk
→ Pilih folder utama project
→ Tunggu proses import selesai
→ Buka scene utama
→ Klik Play
```
