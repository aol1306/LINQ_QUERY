﻿using Cwiczenia6.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Cwiczenia6
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public List<Emp> Emps { get; set; }
        public List<Dept> Depts { get; set; }

        public MainWindow()
        {
            InitializeComponent();
            LoadData();
            Example();
        }

        public void LoadData()
        {
            Emps = new List<Emp>();
            Depts = new List<Dept>();

            Emps.Add(new Emp
            {
                Empno = 7369,
                Ename = "SMITH",
                Job = "CLERK",
                Mgr = 7902,
                HireDate = new DateTime(1980, 12, 17),
                Sal=800,
                Comm=0,
                Deptno=20
            });

            Emps.Add(new Emp
            {
                Empno = 7499,
                Ename = "ALLEN",
                Job = "SALESMAN",
                Mgr = 7698,
                HireDate = new DateTime(1981, 2, 20),
                Sal = 1600,
                Comm = 300,
                Deptno = 30
            });

            Emps.Add(new Emp
            {
                Empno = 7521,
                Ename = "WARD",
                Job = "SALESMAN",
                Mgr = 7698,
                HireDate = new DateTime(1981, 2, 22),
                Sal = 1250,
                Comm = 500,
                Deptno = 30
            });

            Emps.Add(new Emp
            {
                Empno = 7566,
                Ename = "JONES",
                Job = "MANAGER",
                Mgr = 7839,
                HireDate = new DateTime(1981, 4, 2),
                Sal = 2975,
                Comm = 0,
                Deptno = 20
            });

            Emps.Add(new Emp
            {
                Empno = 7654,
                Ename = "MARTIN",
                Job = "SALESMAN",
                Mgr = 7698,
                HireDate = new DateTime(1981, 9, 28),
                Sal = 1250,
                Comm = 1400,
                Deptno = 30
            });

            Emps.Add(new Emp
            {
                Empno = 7698,
                Ename = "BLAKE",
                Job = "MANAGER",
                Mgr = 7839,
                HireDate = new DateTime(1981, 5, 1),
                Sal = 2850,
                Comm = 0,
                Deptno = 30
            });

            Emps.Add(new Emp
            {
                Empno = 7782,
                Ename = "CLARK",
                Job = "MANAGER",
                Mgr = 7839,
                HireDate = new DateTime(1981, 6, 9),
                Sal = 2450,
                Comm = 0,
                Deptno = 10
            });

            Emps.Add(new Emp
            {
                Empno = 7788,
                Ename = "SCOTT",
                Job = "ANALYST",
                Mgr = 7566,
                HireDate = new DateTime(1982, 12, 9),
                Sal = 3000,
                Comm = 0,
                Deptno = 20
            });

            Emps.Add(new Emp
            {
                Empno = 7839,
                Ename = "KING",
                Job = "PRESIDENT",
                Mgr = null,
                HireDate = new DateTime(1981, 11, 17),
                Sal = 5000,
                Comm = 0,
                Deptno = 10
            });

            Emps.Add(new Emp
            {
                Empno = 7844,
                Ename = "TURNER",
                Job = "SALESMAN",
                Mgr = 7698,
                HireDate = new DateTime(1981, 9, 8),
                Sal = 1500,
                Comm = 0,
                Deptno = 30
            });

            Emps.Add(new Emp
            {
                Empno = 7876,
                Ename = "ADAMS",
                Job = "CLERK",
                Mgr = 7788,
                HireDate = new DateTime(1983, 1, 12),
                Sal = 1100,
                Comm = 0,
                Deptno = 20
            });

            Emps.Add(new Emp
            {
                Empno = 7900,
                Ename = "JAMES",
                Job = "CLERK",
                Mgr = 7698,
                HireDate = new DateTime(1981, 12, 3),
                Sal = 950,
                Comm = 0,
                Deptno = 30
            });

            Emps.Add(new Emp
            {
                Empno = 7902,
                Ename = "FORD",
                Job = "ANALYST",
                Mgr = 7566,
                HireDate= new DateTime(1981, 12, 3),
                Sal = 3000,
                Comm = 0,
                Deptno = 20
            });

            Emps.Add(new Emp
            {
                Empno = 7934,
                Ename = "MILLER",
                Job = "CLERK",
                Mgr = 7782,
                HireDate = new DateTime(1982, 1, 23),
                Sal = 1300,
                Comm = 0,
                Deptno = 10
            });

            Depts.Add(new Dept
            {
                Deptno=10,
                Dname= "ACCOUNTING",
                Loc= "NEW YORK"
            });

            Depts.Add(new Dept
            {
                Deptno = 20,
                Dname = "RESEARCH",
                Loc = "DALLAS"
            });

            Depts.Add(new Dept
            {
                Deptno = 30,
                Dname = "SALES",
                Loc = "CHICAGO"
            });

            Depts.Add(new Dept
            {
                Deptno = 40,
                Dname = "OPERATIONS",
                Loc = "BOSTON"
            });
        }

        private void Example()
        {
            //Query syntax
            var result = from e in Emps
                         where e.Ename.StartsWith("K")
                         select e;

            //Lambda and Extension methods syntax
            var result2 = Emps.Where(e => e.Ename.StartsWith("K"));


            DataGrid.ItemsSource = result.ToList();
        }

        private void Task1Btn_Click(object sender, RoutedEventArgs e)
        {
            var result = Emps.Select(emp => new { RPensja = emp.Sal * 12 });
            DataGrid.ItemsSource = result.ToList();

        }

        private void Task2Btn_Click(object sender, RoutedEventArgs e)
        {
            var result = Emps.Select(emp => new { EMPLOYEE = emp.Empno + " " + emp.Ename });
            DataGrid.ItemsSource = result.ToList();
        }

        private void Task3Btn_Click(object sender, RoutedEventArgs e)
        {
            var result = Emps.Select(emp => new { wynik = $"{emp.Ename} pracuje w dziale {emp.Deptno}" });
            DataGrid.ItemsSource = result.ToList();

        }

        private void Task4Btn_Click(object sender, RoutedEventArgs e)
        {
            var result = Emps.Select(emp => new { rocznapensjacalkowita = emp.Sal * 12 + emp.Comm   });
            DataGrid.ItemsSource = result.ToList();
        }

        private void Task5Btn_Click(object sender, RoutedEventArgs e)
        {
            var result = Emps.Select(emp => new { DEPTNO = emp.Deptno });
            DataGrid.ItemsSource = result.ToList();
        }

        private void Task6Btn_Click(object sender, RoutedEventArgs e)
        {
            var result = Emps.Select(emp => new { DEPTNO = emp.Deptno }).Distinct();
            DataGrid.ItemsSource = result.ToList();
        }

        private void Task7Btn_Click(object sender, RoutedEventArgs e)
        {
            var result = Emps.Select(emp => new {
                DEPTNO = emp.Deptno,
                JOB = emp.Job
            }).Distinct();
            DataGrid.ItemsSource = result.ToList();
        }

        private void Task8Btn_Click(object sender, RoutedEventArgs e)
        {
            var result = Emps.OrderBy(emp => emp.Ename);
            DataGrid.ItemsSource = result.ToList();
        }

        private void Task9Btn_Click(object sender, RoutedEventArgs e)
        {
            var result = Emps.OrderByDescending(emp => emp.HireDate);
            DataGrid.ItemsSource = result.ToList();
        }

        private void Task10Btn_Click(object sender, RoutedEventArgs e)
        {
            var result = Emps.OrderBy(emp => emp.Deptno).ThenByDescending(emp=>emp.Sal);
            DataGrid.ItemsSource = result.ToList();
        }

        // GRUPOWANIE
        private void Task11Btn_Click(object sender, RoutedEventArgs e)
        {
            var result = Emps.Join(Depts, emp => emp.Deptno, dept => dept.Deptno, (emp, dept) => emp);

            DataGrid.ItemsSource = result.ToList();

        }

        private void Task12Btn_Click(object sender, RoutedEventArgs e)
        {
            var result = Emps.Join(Depts, emp => emp.Deptno, dept => dept.Deptno, (emp, dept) => new
            {
                DEPT_NAME = dept.Dname,
                ENAME = emp.Ename
            }).OrderBy(emp => emp.ENAME);
            DataGrid.ItemsSource = result.ToList();
        }

        private void Task13Btn_Click(object sender, RoutedEventArgs e)
        {
            var result = Emps.Join(Depts, emp => emp.Deptno, dept => dept.Deptno, (emp, dept) => new
            {
                DEPT_NAME = dept.Dname,
                ENAME = emp.Ename,
                EMPNO = emp.Empno
            });
            DataGrid.ItemsSource = result;
        }

        private void Task14Btn_Click(object sender, RoutedEventArgs e)
        {
            var result = Emps.Where(emp => emp.Sal > 1500)
                .Join(Depts, emp => emp.Deptno, dept => dept.Deptno, (emp, dept) => new
                {
                    ENAME = emp.Ename,
                    DNAME = dept.Dname,
                    LOC = dept.Loc
                });
            DataGrid.ItemsSource = result.ToList();
        }

        private void Task15Btn_Click(object sender, RoutedEventArgs e)
        {
            var result = Emps.Join(Depts, emp => emp.Deptno, dept => dept.Deptno, (emp, dept) => new
            {
                ENAME = emp.Ename,
                LOC = dept.Loc
            }).Where(a => a.LOC == "DALLAS");
            DataGrid.ItemsSource = result.ToList();
        }

        // GRUPOWANIE

        private void Task16Btn_Click(object sender, RoutedEventArgs e)
        {
            var result = Emps.Average(emp => emp.Sal);
            MessageBox.Show(result.ToString());
        }

        private void Task17Btn_Click(object sender, RoutedEventArgs e)
        {
            var result = Emps.Where(emp => emp.Job == "CLERK").Min(emp => emp.Sal);
            MessageBox.Show(result.ToString());
        }

        private void Task18Btn_Click(object sender, RoutedEventArgs e)
        {
            var result = Emps.Where(emp => emp.Deptno == 20).Count();
            MessageBox.Show(result.ToString());
        }

        private void Task19Btn_Click(object sender, RoutedEventArgs e)
        {
            var result = Emps.GroupBy(emp => emp.Job, emp => emp.Sal, (key, g) => new { JOB = key, AVG_SAL = g.Average() });
            DataGrid.ItemsSource = result.ToList();
        }

        private void Task20Btn_Click(object sender, RoutedEventArgs e)
        {
            var result = Emps.Where(emp => emp.Job != "MANAGER").GroupBy(emp => emp.Job, emp => emp.Sal, (key, g) => new { JOB = key, AVG_SAL = g.Average() });
            DataGrid.ItemsSource = result.ToList();
        }

        // PODZAPYTANKA

        private void Task21Btn_Click(object sender, RoutedEventArgs e)
        {
            var result = Emps.Where(emp => emp.Sal == Emps.Min(emp2 => emp2.Sal));
            DataGrid.ItemsSource = result.ToList();
        }

        private void Task22Btn_Click(object sender, RoutedEventArgs e)
        {
            var blakesJob = Emps.Where(emp => emp.Ename == "BLAKE").ToList().FirstOrDefault().Job;
            var result = Emps.Where(emp => emp.Job == blakesJob);
            DataGrid.ItemsSource = result.ToList();
        }

        private void Task23Btn_Click(object sender, RoutedEventArgs e)
        {
            var listaNajnizszych = Emps.GroupBy(emp => emp.Deptno, emp => emp.Sal, (key, g) => new { DEPTNO = key, MIN_SAL = g.Min() });
            var result = listaNajnizszych.Join(Emps, emp => emp.MIN_SAL, emp2 => emp2.Sal, (emp, emp2) => emp2);
            DataGrid.ItemsSource = result.ToList();
        }

        private void Task24Btn_Click(object sender, RoutedEventArgs e)
        {
            var listaNajnizszych = Emps.GroupBy(emp => emp.Deptno, emp => emp.Sal, (key, g) => new { DEPTNO = key, MIN_SAL = g.Min() });
            var result = listaNajnizszych.Join(Emps, emp => emp.MIN_SAL, emp2 => emp2.Sal, (emp, emp2) => emp2);
            DataGrid.ItemsSource = result.ToList();
        }

        private void Task25Btn_Click(object sender, RoutedEventArgs e)
        {
            var listaSrednich = Emps.GroupBy(emp => emp.Deptno, emp => emp.Sal, (key, g) => new { DEPTNO = key, AVG_SAL = g.Average() });
            var result = Emps.Where(emp => emp.Sal > listaSrednich.Where(a => a.DEPTNO == emp.Deptno).ToList().FirstOrDefault().AVG_SAL);
            DataGrid.ItemsSource = result.ToList();
        }
    }
}
