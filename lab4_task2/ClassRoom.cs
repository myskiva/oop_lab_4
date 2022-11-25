using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task4
{
    class Program
    {
        static void Main(string[] args)
        {
            ClassRoom classRoom = new ClassRoom();
            ExcelentPupil excelentPupil = new ExcelentPupil();
            GoodPupil goodPupil = new GoodPupil();
            BadPupil badPupil = new BadPupil();
            NormalPupil normalPupil = new NormalPupil();

            classRoom.Entrie(excelentPupil);
            classRoom.Entrie(goodPupil);
            classRoom.Entrie(badPupil);
            classRoom.Entrie(normalPupil);
        }
    }

    class ClassRoom
    {
        public void Entrie(Pupil pupil)
        {
            pupil.Study();
            pupil.Read();
            pupil.Write();
            pupil.Relax();
        }
    }

    abstract class Pupil
    {
        public abstract void Study();
        public abstract void Read();
        public abstract void Write();
        public abstract void Relax();
    }


    class ExcelentPupil : Pupil
    {
        public override void Study()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Pupil studies excellently");
        }

        public override void Read()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Pupil reads excellently");
        }

        public override void Write()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Pupil writes excellently");
        }

        public override void Relax()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Pupil rest badly\n");
        }

    }

    class GoodPupil : Pupil
    {
        public override void Study()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Pupil studies good");
        }

        public override void Read()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Pupil reads good");
        }

        public override void Write()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Pupil writes good");
        }

        public override void Relax()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Pupil rest so-so\n");
        }

    }

    class BadPupil : Pupil
    {
        public override void Study()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Pupil studies badly");
        }

        public override void Read()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Pupil reads badly");
        }

        public override void Write()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Pupil writes badly");
        }

        public override void Relax()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Pupil rest awesome\n");
        }
    }

    class NormalPupil : Pupil
    {
        public override void Study()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Pupil studies so-so");
        }

        public override void Read()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Pupil reads good");
        }

        public override void Write()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Pupil writes good");
        }

        public override void Relax()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Pupil rest awesome\n");
        }
    }
}