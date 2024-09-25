using System;


public class ClassRoom 
{
    private Pupil p1, p2, p3, p4;

    public ClassRoom(params Pupil[] parameters) 
    {
        p1 = parameters[0];
        p2 = parameters[1];
        if (parameters.Length > 2)
        { 
            p3 = parameters[2]; 
        }
        if (parameters.Length > 3)
        {
            p4 = parameters[3];
        }
    }

    public void Print() 
    {
        Pupil[] arr = new Pupil[4];
        arr[0] = p1;
        arr[1] = p2;
        arr[2] = p3;
        arr[3] = p4;
        for (int i = 0; i < 4; ++i)
        {
            if (arr[i] == default) break;
            Console.WriteLine($"{i+1}-ый ученик:");
            arr[i].Study();
            arr[i].Read();
            arr[i].Write();
            arr[i].Relax();
            Console.WriteLine("");
        }
    }
}

public class Pupil 
{
    public virtual void Study() { }
    public virtual void Read() { }
    public virtual void Write() { }
    public virtual void Relax() { }
}

public class ExcelentPupil: Pupil
{
    public override void Study()
    {
        Console.WriteLine("Учится отлично");
    }

    public override void Read()
    {
        Console.WriteLine("Читает отлично");
    }

    public override void Write()
    {
        Console.WriteLine("Пишет отлично");
    }

    public override void Relax()
    {
        Console.WriteLine("Отдыхает отлично");
    }
}

public class GoodPupil : Pupil
{
    public override void Study()
    {
        Console.WriteLine("Учится хорошо");
    }

    public override void Read()
    {
        Console.WriteLine("Читает хорошо");
    }

    public override void Write()
    {
        Console.WriteLine("Пишет хорошо");
    }

    public override void Relax()
    {
        Console.WriteLine("Отдыхает хорошо");
    }
}

public class BadPupil : Pupil
{
    public override void Study()
    {
        Console.WriteLine("Учится плохо");
    }

    public override void Read()
    {
        Console.WriteLine("Читает плохо");
    }

    public override void Write()
    {
        Console.WriteLine("Пишет плохо");
    }

    public override void Relax()
    {
        Console.WriteLine("Отдыхает плохо");
    }
}

namespace Task1
{
    public class Program
    {
        static void Main()
        {
            ExcelentPupil exсel = new ExcelentPupil();
            GoodPupil good1 = new GoodPupil();
            BadPupil bad = new BadPupil();
            GoodPupil good2 = new GoodPupil();
            ClassRoom room = new ClassRoom(exсel, good1, bad, good2);
            room.Print();
        }
    }
}
