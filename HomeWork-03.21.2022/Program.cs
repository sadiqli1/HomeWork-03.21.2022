﻿using System;

namespace HomeWork_03._21._2022
{
    class Program
    {
        static void Main(string[] args)
        {
            Word word = new Word("Salam");
            Excel excel = new Excel("Dunya");
            Pdf pdf = new Pdf("Salam");
            MainPrintFile<Word> mainPrintFile = new MainPrintFile<Word>(word);
            //MainPrintFile<Excel> mainPrintFile = new MainPrintFile<Excel>(excel);
            //MainPrintFile<Pdf> mainPrintFile = new MainPrintFile<Pdf>(pdf);
        }
    }
}
