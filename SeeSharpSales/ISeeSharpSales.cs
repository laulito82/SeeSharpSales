using System;
using System.Collections.Generic;
using System.Text;


namespace SeeSharpSales
{
    public interface ISeeSharpSales 
    {
        string filepath { get; }

        string ChooseFileToAnalyse();

        void CheckIfFileIsValid();

    }
}


