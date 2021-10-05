using System;

namespace ConsoleCrawler
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Variable List
            string cellNumber;
            string cell0 = "0";
            string cell1 = "0";
            string cell2 = "0";
            string cell3 = "0";
            string cell4 = "0";
            string cell5 = "0";
            string cell6 = "0";
            string cell7 = "0";
            string cell8 = "0";
            string cell9 = "0";
            string cell10 = "0";
            string cell11 = "0";
            string cell12 = "0";
            string cell13 = "0";
            string cell14 = "0";
            string cell15 = "0";
            string cell16 = "0";
            string cell17 = "0";
            string cell18 = "0";
            string cell19 = "0";
            string cell20 = "0";
            string cell21 = "0";
            string cell22 = "0";
            string cell23 = "0";
            string cell24 = "0";
            string cell25 = "0";
            string cell26 = "0";
            string cell27 = "0";
            string cell28 = "0";
            string cell29 = "0";
            string cell30 = "0";
            string cell31 = "0";
            string cell32 = "0";
            string cell33 = "0";
            string cell34 = "0";
            string cell35 = "0";
            string cell36 = "0";
            string cell37 = "0";
            string cell38 = "0";
            string cell39 = "0";
            string cell40 = "0";
            string cell41 = "0";
            string cell42 = "0";
            string cell43 = "0";
            string cell44 = "0";
            string cell45 = "0";
            string cell46 = "0";
            string cell47 = "0";
            string cell48 = "0";
            string cell49 = "0";
            string cell50 = "0";
            string cell51 = "0";
            string cell52 = "0";
            string cell53 = "0";
            string cell54 = "0";
            string cell55 = "0";
            string cell56 = "0";
            string cell57 = "0";
            string cell58 = "0";
            string cell59 = "0";
            string cell60 = "0";
            string cell61 = "0";
            string cell62 = "0";
            string cell63 = "0";
            string cell64 = "0";
            string cell65 = "0";
            string cell66 = "0";
            string cell67 = "0";
            string cell68 = "0";
            string cell69 = "0";
            string cell70 = "0";
            string cell71 = "0";
            string cell72 = "0";
            string cell73 = "0";
            string cell74 = "0";
            string cell75 = "0";
            string cell76 = "0";
            string cell77 = "0";
            string cell78 = "0";
            string cell79 = "0";
            string cell80 = "0";
            string cell81 = "0";
            string cell82 = "0";
            string cell83 = "0";
            string cell84 = "0";
            string cell85 = "0";
            string cell86 = "0";
            string cell87 = "0";
            string cell88 = "0";
            string cell89 = "0";
            string cell90 = "0";
            string cell91 = "0";
            string cell92 = "0";
            string cell93 = "0";
            string cell94 = "0";
            string cell95 = "0";
            string cell96 = "0";
            string cell97 = "0";
            string cell98 = "0";
            string cell99 = "0";
            string cell100 = "0";
            string cell101 = "0";
            string cell102 = "0";
            string cell103 = "0";
            string cell104 = "0";
            string cell105 = "0";
            string cell106 = "0";
            string cell107 = "0";
            string cell108 = "0";
            string cell109 = "0";
            string cell110 = "0";
            string cell111 = "0";
            string cell112 = "0";
            string cell113 = "0";
            string cell114 = "0";
            string cell115 = "0";
            string cell116 = "0";
            string cell117 = "0";
            string cell118 = "0";
            string cell119 = "0";
            string cell120 = "0";
            string cell121 = "0";
            string cell122 = "0";
            string cell123 = "0";
            string cell124 = "0";
            string cell125 = "0";
            string cell126 = "0";
            string cell127 = "0";
            string cell128 = "0";
            string cell129 = "0";
            string cell130 = "0";
            string cell131 = "0";
            string cell132 = "0";
            string cell133 = "0";
            string cell134 = "0";
            string cell135 = "0";
            string cell136 = "0";
            string cell137 = "0";
            string cell138 = "0";
            string cell139 = "0";
            string cell140 = "0";
            string cell141 = "0";
            string cell142 = "0";
            string cell143 = "0";
            string cell144 = "0";
            string cell145 = "0";
            string cell146 = "0";
            string cell147 = "0";
            string cell148 = "0";
            string cell149 = "0";
            string cell150 = "0";
            string cell151 = "0";
            string cell152 = "0";
            */

            int[] values = new int[4] {0, 1, 2, 3};

            //Stage
            int stage = 0;
            int cellNumber = 0;

            /*switch (stage)
            {
                
            }
            int Number = 0;*/

            for (int i = 0; i < 160; i++)
            {
                cellNumber++;
                if (cellNumber % 16 == 0)
                {
                    Console.WriteLine("0" + " ");
                }
                else
                {
                    Console.Write("0" + " ");
                }
            }


            /*Row One
            Console.Write(cell0 + " ");
            Console.Write(cell1 + " ");
            Console.Write(cell2 + " ");
            Console.Write(cell3 + " ");
            Console.Write(cell4 + " ");
            Console.Write(cell5 + " ");
            Console.Write(cell6 + " ");
            Console.Write(cell7 + " ");
            Console.Write(cell8 + " ");
            Console.Write(cell9 + " ");
            Console.Write(cell10 + " ");
            Console.Write(cell11 + " ");
            Console.Write(cell12 + " ");
            Console.Write(cell13 + " ");
            Console.Write(cell14 + " ");
            Console.Write(cell15 + " ");
            Console.WriteLine(cell16);
            //Row Two
            Console.Write(cell17 + " ");
            Console.Write(cell18 + " ");
            Console.Write(cell19 + " ");
            Console.Write(cell20 + " ");
            Console.Write(cell21 + " ");
            Console.Write(cell22 + " ");
            Console.Write(cell23 + " ");
            Console.Write(cell24 + " ");
            Console.Write(cell25 + " ");
            Console.Write(cell26 + " ");
            Console.Write(cell27 + " ");
            Console.Write(cell28 + " ");
            Console.Write(cell29 + " ");
            Console.Write(cell30 + " ");
            Console.Write(cell31 + " ");
            Console.Write(cell32 + " ");
            Console.WriteLine(cell33);
            //Row Three
            Console.Write(cell34 + " ");
            Console.Write(cell35 + " ");
            Console.Write(cell36 + " ");
            Console.Write(cell37 + " ");
            Console.Write(cell38 + " ");
            Console.Write(cell39 + " ");
            Console.Write(cell40 + " ");
            Console.Write(cell41 + " ");
            Console.Write(cell42 + " ");
            Console.Write(cell43 + " ");
            Console.Write(cell44 + " ");
            Console.Write(cell45 + " ");
            Console.Write(cell46 + " ");
            Console.Write(cell47 + " ");
            Console.Write(cell48 + " ");
            Console.Write(cell49 + " ");
            Console.WriteLine(cell50);
            //Row Four
            Console.Write(cell51 + " ");
            Console.Write(cell52 + " ");
            Console.Write(cell53 + " ");
            Console.Write(cell54 + " ");
            Console.Write(cell55 + " ");
            Console.Write(cell56 + " ");
            Console.Write(cell57 + " ");
            Console.Write(cell58 + " ");
            Console.Write(cell59 + " ");
            Console.Write(cell60 + " ");
            Console.Write(cell61 + " ");
            Console.Write(cell62 + " ");
            Console.Write(cell63 + " ");
            Console.Write(cell64 + " ");
            Console.Write(cell65 + " ");
            Console.Write(cell66 + " ");
            Console.WriteLine(cell67);
            //Row Five
            Console.Write(cell68 + " ");
            Console.Write(cell69 + " ");
            Console.Write(cell70 + " ");
            Console.Write(cell71 + " ");
            Console.Write(cell72 + " ");
            Console.Write(cell73 + " ");
            Console.Write(cell74 + " ");
            Console.Write(cell75 + " ");
            Console.Write(cell76 + " ");
            Console.Write(cell77 + " ");
            Console.Write(cell78 + " ");
            Console.Write(cell79 + " ");
            Console.Write(cell80 + " ");
            Console.Write(cell81 + " ");
            Console.Write(cell82 + " ");
            Console.Write(cell83 + " ");
            Console.WriteLine(cell84);
            //Row Six
            Console.Write(cell85 + " ");
            Console.Write(cell86 + " ");
            Console.Write(cell87 + " ");
            Console.Write(cell88 + " ");
            Console.Write(cell89 + " ");
            Console.Write(cell90 + " ");
            Console.Write(cell91 + " ");
            Console.Write(cell92 + " ");
            Console.Write(cell93 + " ");
            Console.Write(cell94 + " ");
            Console.Write(cell95 + " ");
            Console.Write(cell96 + " ");
            Console.Write(cell97 + " ");
            Console.Write(cell98 + " ");
            Console.Write(cell99 + " ");
            Console.Write(cell100 + " ");
            Console.WriteLine(cell101);
            //Row Seven
            Console.Write(cell102 + " ");
            Console.Write(cell103 + " ");
            Console.Write(cell104 + " ");
            Console.Write(cell105 + " ");
            Console.Write(cell106 + " ");
            Console.Write(cell107 + " ");
            Console.Write(cell108 + " ");
            Console.Write(cell109 + " ");
            Console.Write(cell110 + " ");
            Console.Write(cell111 + " ");
            Console.Write(cell112 + " ");
            Console.Write(cell113 + " ");
            Console.Write(cell114 + " ");
            Console.Write(cell115 + " ");
            Console.Write(cell116 + " ");
            Console.Write(cell117 + " ");
            Console.WriteLine(cell118);
            //Row Eight
            Console.Write(cell119 + " ");
            Console.Write(cell120 + " ");
            Console.Write(cell121 + " ");
            Console.Write(cell122 + " ");
            Console.Write(cell123 + " ");
            Console.Write(cell124 + " ");
            Console.Write(cell125 + " ");
            Console.Write(cell126 + " ");
            Console.Write(cell127 + " ");
            Console.Write(cell128 + " ");
            Console.Write(cell129 + " ");
            Console.Write(cell130 + " ");
            Console.Write(cell131 + " ");
            Console.Write(cell132 + " ");
            Console.Write(cell133 + " ");
            Console.Write(cell134 + " ");
            Console.WriteLine(cell135);
            //Row Nine
            Console.Write(cell136 + " ");
            Console.Write(cell137 + " ");
            Console.Write(cell138 + " ");
            Console.Write(cell139 + " ");
            Console.Write(cell140 + " ");
            Console.Write(cell141 + " ");
            Console.Write(cell142 + " ");
            Console.Write(cell143 + " ");
            Console.Write(cell144 + " ");
            Console.Write(cell145 + " ");
            Console.Write(cell146 + " ");
            Console.Write(cell147 + " ");
            Console.Write(cell148 + " ");
            Console.Write(cell149 + " ");
            Console.Write(cell150 + " ");
            Console.Write(cell151 + " ");
            Console.Write(cell152 + " ");*/
        }
    }
}
