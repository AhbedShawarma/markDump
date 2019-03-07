using System;
using System.Collections;

public class Expectation
{
    public ArrayList assignmentList = new ArrayList();
    public string name;
    public double mark, weight;

    public Expectation(string n, double w)
	{
        name = n;
        weight = w;
   	}
}
