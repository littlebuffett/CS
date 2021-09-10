﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ch2_Method
{
    class 성적입력3단계
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("학번 입력:");
                int hakbun = int.Parse(Console.ReadLine());
                if (hakbun == -999) break;
                Console.Write("이름 입력:");
                String name = Console.ReadLine();
                Console.Write("국어 입력:");
                int kor = int.Parse(Console.ReadLine());
                while (isOver(kor))
                {
                    Console.Write("국어점수 다시  입력:");
                    kor = int.Parse(Console.ReadLine());
                }
                Console.Write("영어 입력:");
                int eng = int.Parse(Console.ReadLine());
                while (isOver(eng))
                {
                    Console.Write("영어점수 다시  입력:");
                    eng = int.Parse(Console.ReadLine());
                }
                Console.Write("수학 입력:");
                int mat = int.Parse(Console.ReadLine());
                while (isOver(mat))
                {
                    Console.Write("수학점수 다시  입력:");
                    mat = int.Parse(Console.ReadLine());
                }

                int tot = kor + eng + mat;
                double aver = tot / 3;

                Console.WriteLine("{0} {1}  {2} {3}  {4}  {5} {6:F2} \n", hakbun, name, kor, eng, mat, tot, aver);

            }
            Console.WriteLine("성적처리 끝");
        }

        static bool isOver(int a)
        {
            if (a >= 0 && a <= 100) return false;
            else return true;
        }
    }
}
