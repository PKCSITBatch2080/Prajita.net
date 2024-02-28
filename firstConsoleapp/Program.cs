﻿using System;

Console.WriteLine(5567564);

DataTypes dt = new();
dt.Learn();

Methods m = new Methods();
m.Greet("Hi");
m.CalculateBMI(233.33f,343.34f);
var highest=m.GetMax([3,4,5,6,78,23.4]);
var highest2=m.GetMax([3,4,5,6,78]);
var highest3=m.GetMax([3,4,5,6]);
var highest4=m.GetMax([3,4,5,6,78,23.4]);

Generics g=new();
g.Display<string>("bjhdbcv");
g.Display<int>(534);

Student Prakriti = new Student("Prakriti",11);
var Prajita = new Student(); //also can write var instead of Student


CSstudent anupa = new CSstudent("Prakriti Gurung",8, "Hello Doctor");
anupa.DisplayInfo();

var reshma = new CyberSecurityStudent("Reshma Shretha", 11, "RHS","Redhat");