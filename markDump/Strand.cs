using System;
using System.Collections;

public class Strand
{
    public ArrayList expectationList = new ArrayList();
    public string name;
    public double mark, weight;

    public Strand(string n, double w)
    {
        name = n;
        weight = w;
    }

    public double CalculateMark()
    {        
        foreach (Expectation e in expectationList)
        {
            e.mark = 0;

            foreach (Assignment a in e.assignmentList)
            {
                e.mark += a.mark * a.weight;
            }

            mark += e.mark * e.weight;
        }

        return mark;
    }
}
  
