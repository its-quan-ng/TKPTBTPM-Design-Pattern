using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225461_NguyenThiBichQuan_MyWorld08_FileSystem
{
    public class Program
    {
        static void Main(string[] args)
        {
            Folder root = new Folder("THIS PC");

            root.Add(new File("README.txt", 5));
            root.Add(new File("setup.exe", 2500));

            Folder documents = new Folder("Documents");
            documents.Add(new File("Report.pdf", 1200));
            documents.Add(new File("Invoice.docx", 350));

            Folder photos = new Folder("Photos");
            photos.Add(new File("vacation1.jpg", 4500));
            photos.Add(new File("vacation2.jpg", 4800));

            Folder familyPhotos = new Folder("Family");
            familyPhotos.Add(new File("dad.jpg", 3200));
            familyPhotos.Add(new File("mom.jpg", 3100));
            photos.Add(familyPhotos);

            Folder work = new Folder("Workspace");
            work.Add(new File("Project.docx", 780));
            work.Add(new File("Budget.xlsx", 120));

            Folder code = new Folder("Code");
            code.Add(new File("Main.cs", 45));
            code.Add(new File("Helper.cs", 32));
            work.Add(code);

            root.Add(documents);
            root.Add(photos);
            root.Add(work);

            root.Display(0);
            Console.ReadKey();

        }
    }
}
