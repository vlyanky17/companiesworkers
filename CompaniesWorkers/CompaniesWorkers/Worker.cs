using System;
using System.Collections.Generic;
using System.Text;

namespace CompaniesWorkers
{
    class Worker // класс работника
    {
       public string WorkerSurname;
        public string WorkerName;
        public string WorkerPatronymic;
        public string WorkerDate;
        public string WorkerSpecific;
        public string WorkerCompany;

        public Worker(string s, string n,string p,string d,string f,string i) { WorkerSurname = s; WorkerName = n; WorkerPatronymic = p; WorkerDate = d; WorkerSpecific = f; WorkerCompany = i; }
    }
}
