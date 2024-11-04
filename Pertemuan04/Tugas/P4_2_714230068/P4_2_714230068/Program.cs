using System;
using System.Collections.Generic;

namespace P4_2_714230068
{
    // Abstraction - Membuat kelas abstrak Task
    public abstract class Task
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public bool IsCompleted { get; protected set; }

        // Constructor - Menginisialisasi judul dan deskripsi
        public Task(string title, string description)
        {
            Title = title;
            Description = description;
            IsCompleted = false;
        }

        // Polymorphism - Deklarasi metode abstrak yang harus diimplementasi oleh kelas turunan
        public abstract void MarkAsCompleted();

        // Encapsulation - Mengatur akses untuk properti
        public void DisplayInfo()
        {
            Console.WriteLine($"Title: {Title}");
            Console.WriteLine($"Description: {Description}");
            Console.WriteLine($"Status: {(IsCompleted ? "Completed" : "Incomplete")}");
        }
    }

    // Inheritance - Kelas ToDoTask mewarisi kelas Task
    public class ToDoTask : Task
    {
        // Constructor - Memanggil constructor dari kelas induk
        public ToDoTask(string title, string description) : base(title, description)
        {
        }

        // Polymorphism - Mengimplementasikan metode MarkAsCompleted
        public override void MarkAsCompleted()
        {
            IsCompleted = true;
            Console.WriteLine($"Task '{Title}' marked as completed!");
        }
    }

    public class Program
    {
        static void Main(string[] args)
        {
            // Membuat daftar tugas
            List<ToDoTask> tasks = new List<ToDoTask>();

            while (true)
            {
                Console.WriteLine("\nTo-Do List Menu:");
                Console.WriteLine("1. Tambah Tugas");
                Console.WriteLine("2. Lihat Daftar Tugas");
                Console.WriteLine("3. Tandai Tugas sebagai Selesai");
                Console.WriteLine("4. Keluar");
                Console.Write("Pilih opsi (1-4): ");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        AddTask(tasks);
                        break;
                    case "2":
                        DisplayTasks(tasks);
                        break;
                    case "3":
                        MarkTaskAsCompleted(tasks);
                        break;
                    case "4":
                        Console.WriteLine("Keluar dari program. Terima kasih!");
                        return;
                    default:
                        Console.WriteLine("Pilihan tidak valid. Silakan pilih opsi 1-4.");
                        break;
                }
            }
        }

        // Method untuk menambahkan tugas baru
        static void AddTask(List<ToDoTask> tasks)
        {
            Console.Write("\nMasukkan judul tugas: ");
            string title = Console.ReadLine();
            Console.Write("Masukkan deskripsi tugas: ");
            string description = Console.ReadLine();

            ToDoTask newTask = new ToDoTask(title, description);
            tasks.Add(newTask);

            Console.WriteLine($"Tugas '{title}' berhasil ditambahkan!");
        }

        // Method untuk menampilkan semua tugas
        static void DisplayTasks(List<ToDoTask> tasks)
        {
            Console.WriteLine("\nDaftar Tugas:");
            if (tasks.Count == 0)
            {
                Console.WriteLine("Tidak ada tugas dalam daftar.");
            }
            else
            {
                int index = 1;
                foreach (var task in tasks)
                {
                    Console.WriteLine($"\nTugas {index}:");
                    task.DisplayInfo();
                    index++;
                }
            }
        }

        // Method untuk menandai tugas sebagai selesai
        static void MarkTaskAsCompleted(List<ToDoTask> tasks)
        {
            Console.WriteLine("\nTandai Tugas sebagai Selesai:");
            if (tasks.Count == 0)
            {
                Console.WriteLine("Tidak ada tugas dalam daftar.");
                return;
            }

            Console.Write("Masukkan nomor tugas yang ingin ditandai selesai: ");
            if (int.TryParse(Console.ReadLine(), out int taskNumber) && taskNumber > 0 && taskNumber <= tasks.Count)
            {
                tasks[taskNumber - 1].MarkAsCompleted();
            }
            else
            {
                Console.WriteLine("Nomor tugas tidak valid.");
            }
        }
    }
}
