using System;
using System.Collections;

public class Strand
{
    public ArrayList expectationList = new ArrayList();
    public double mark, weight;

    public Strand(double m, double w)
    {
        mark = m;
        weight = w;
    }
    /* For each Expectation in Strand.ExpectationsList:
        For each Assignment in Expectation.AssigmentsList:
            Expectation.Mark += Assignment.Weight * Assignment.Mark
    Strand.Mark += Expectation.Mark * Expectation.Weight
    */
    public double CalculateMark()
    {
        double mark = 0;
        
        foreach (Expectation e in expectationList)
        {
            foreach (Assignment a in e.assignmentList)
            {
                e.mark += a.weight * a.mark;
            }

            this.mark += e.mark * e.weight;
        }

        return mark;
    }
}
  
