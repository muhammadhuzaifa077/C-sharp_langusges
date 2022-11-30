// See https://aka.ms/new-console-template for more information

class Program 
{



        /*except main function 
        all the function start from here*/

        static void mymethods(string fname, int age ,string color)
        {
            Console.WriteLine("hello " + fname +" ,\nyour age is =  " + age + ", \nyour favourite colur is = " + color);
        }


        static void MyMethod(string country = "Norway") 
        {
            Console.WriteLine(country);
        }

        static int div(int x , int y )
        {
            return x / y ;
        }
        static int mul(int x , int y )
        {
            return x * y ;
        }
        static int sum(int x , int y )
        {
            return x + y ;
        }
        static int sub(int x , int y )
        {
            return x - y ;
        }

        static void argument(string child1,string child2,string child3)
        {
            Console.WriteLine("\nthe youngest child is = " + child3 +"\nthe eldest child is = " + child1);
        }

        static int PlusMethod(int x ,int y)
        {
            return x + y;
        }

           static double PlusMethod(double x ,double y)
        {
            return x * y;
        }

        
        /*except main function 
        all the function start from here*/






      /*all the command pass in main function 
      which is start from here*/

    static void Main()
    {


        //executed all methods are start from here

            mymethods("Huzaifa" ,17 , "black");
            mymethods("Shakir" ,19 , "black");

            MyMethod("\nSweden");
            MyMethod("India");
            MyMethod();
            MyMethod("USA\n");

            Console.WriteLine(div(30,5));
            Console.WriteLine(mul(7,7));

            int b =sum (20 ,6);
            Console.WriteLine(b);

            int c =sub (20 ,5);
            Console.WriteLine(c);

            argument(child2 : "jhon" , child3 : "huzaifa" , child1 : "shakir");

            int num1 = PlusMethod(3,5);
            double num2 = PlusMethod(3.5,5.5);
            Console.WriteLine("\nint = " + num1);
            Console.WriteLine("double = " + num2);


            //executed all methods are end from here

   
           



           // start of console.writeline command

            Console.WriteLine("\nHello, World!");
            Console.WriteLine("hello huzaifa");
            Console.WriteLine("how are you ?");
            Console.WriteLine("I am learning C#");
            Console.WriteLine("It is awesome\n");

            // end of console.writeline command






           /// just an add operator of C#
            Console.WriteLine(34 + 54);





            /*all variable and 
            datatypes start from here.*/


            string lines = "\nthis is a string";     // String
            int myNum = 5;                         // Integer (whole number)
            double myDoubleNum = 5.99D;            // double point number
            char myLetter = 'D';                   // Character
            char myGrade = 'A';                    // char 
            bool myBoolean = true;                 // Boolean
            float myfloat = 5.75e5F;               //floating point number

            Console.WriteLine(lines);
            Console.WriteLine(myNum);
            Console.WriteLine(myDoubleNum);
            Console.WriteLine(myLetter);
            Console.WriteLine(myGrade);
            Console.WriteLine(myBoolean);
            Console.WriteLine(myfloat);


            // just constant variable means whih we cannot  assing the new values of the same name variable.

            const int myvari = 23;
            Console.WriteLine(myvari + "\n");


            // display variables.

            string name = "\nhuzaifa";
            Console.WriteLine("hello" + name);

            string firstname = "muhammad";
            string secondname = "huzaifa";
            string fullname = firstname + secondname;
            Console.WriteLine(fullname);

            int numm1 = 43;
            int numm2 = 62;
            Console.WriteLine(numm1 + numm2);


            int num3 = 526;
            int num4 = 62;
            int addnum = num3 + num4;
            Console.WriteLine(addnum +"\n");



            //Multiple variables

            int x, y, z;
            x = y = z = 50;
            Console.WriteLine(x + y + z);

            int a, be, ce;
            a = be = ce = 50;
            Console.WriteLine(a - be - ce);


            int d, e, f;
            d = e = f = 5;
            Console.WriteLine(d * e * f);

            int g, h, i;
            g = h = i = 10;
            Console.WriteLine(g / h + i + "\n");

            /*all variable and 
            datatypes end from here.*/







             /* complete type casting
             examples start from here*/



            //implicit cating small datatype from large datatype (automatically)

            int number = 54;
            double doub = number;

            Console.WriteLine(number);
            Console.WriteLine(doub + "\n");

            // explicit casting large datatypefrom samll datatype (manually)

            double nume = 65.6;
            char lette = (char)nume;

            Console.WriteLine(nume);
            Console.WriteLine(lette);



            double numer = 65.5;
            int lett = (int)nume;

            Console.WriteLine(numer);
            Console.WriteLine(lett + "\n");

            
             /* complete type casting
             examples end from here*/







            /*type conversion metthods
            are start from here*/

            int myInt = 10;
            double myDouble = 5.25;
            bool myBoole = true ;



            Console.WriteLine(Convert.ToInt64(myInt));
            Console.WriteLine(Convert.ToInt32(myDouble));
            Console.WriteLine(Convert.ToString(myBoole));


            Console.WriteLine("Enter username:");

            /*type conversion metthods
            are end from here*/







            /* user input program
            start from here*/

            // Create a string variable and get user input from the keyboard and store it in the variable
            var userName = Console.ReadLine();

            // Print the value of the variable (userName), which will display the input value
            Console.WriteLine("Username is = " + userName);



            Console.WriteLine("enter your age");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("your age is = " + age);


            Console.WriteLine("enter your e-mail");
            var email = Console.ReadLine();
            Console.WriteLine("your email is = " + email + "\n");

            /*type conversion metthods
            are start from here*/







            /* start of all Operators*/

            //arithematic operators 

            int sum1 = 300 + 200;
            int sum2 = sum1 + 300;
            int sum3 = sum1 + sum2;

            Console.WriteLine(sum1);
            Console.WriteLine(sum2);
            Console.WriteLine(sum3 +"\n");

            int sub1 = 300 - 200;
            int sub2 = sub1 - 300;
            int sub3 = sub1 - sub2;

            Console.WriteLine(sub1);
            Console.WriteLine(sub2);
            Console.WriteLine(sub3 +"\n");


            int mul1 = 34 * 5;
            int mul2 = mul1 * 5;
            int mul3 = mul1 * mul2;

            Console.WriteLine(mul1);
            Console.WriteLine(mul2);
            Console.WriteLine(mul3 +"\n");

            int div1 = 50 / 7;
            int div2 = div1 / 4;
            int div3 = div1 / div2;

            Console.WriteLine(div1);
            Console.WriteLine(div2);
            Console.WriteLine(div3+"\n");


            int p = 4;
            p++;
            Console.WriteLine(p);

            int q =50;
            int v= 50;
            q ++;
            v --;
            int w = q+v;
            Console.WriteLine(w);


            int o=50 %5;
            int s=45%9;
            o ++;
            s --;
            int t = o*s/o+s-o;
            Console.WriteLine(t +"\n");



            //assignment operators

            int u =6;
            Console.WriteLine(u);


            int A = 7;
            A +=6;
            Console.WriteLine(A);

            int B =65;
            B -= 5;
            Console.WriteLine(B);

            int C =7;
            C *=7;
            Console.WriteLine(C);

            int D =49;
            D /=7;
            Console.WriteLine(D);

            int E =65;
            E %=8;
            Console.WriteLine(E +"\n");

            //remaining//



           //camparison operators//

            int F = 5;
            int G = 9;
            Console.WriteLine(F==G);

            int H=6;
            int I =5;
            Console.WriteLine(H!=I);

            int J =7;
            int K=8;
            Console.WriteLine(J>K);

            int L =7;
            int M=8;
            Console.WriteLine(L<M);

            int N =9;
            int O=8;
            Console.WriteLine(N>=O);
            Console.WriteLine(N<=O);

            int P =10;
            int Q =10;
            Console.WriteLine(P>=Q );



            //logiacal operators
           Console.WriteLine(15 > 5 && 15 < 20);
           Console.WriteLine(15 < 5 || 15 > 20);
           Console.WriteLine(!(15 > 5 && 15 < 20));
           Console.WriteLine(!(15 < 5 || 15 > 20 ));


            /* end of all Operators*/








           /*Maths program start
           in c# from here */

           Console.WriteLine(Math.Max(10,20));
           Console.WriteLine(Math.Min(10,20));
           Console.WriteLine(Math.Max(10*7,20*3));

           Console.WriteLine(Math.Sqrt(4));
           Console.WriteLine(Math.Sqrt(64));

           Console.WriteLine(Math.Round(99.87));
           Console.WriteLine(Math.Round(99.34));

           Console.WriteLine(Math.Abs(-443.76));

             /*Maths program end
           in c# from here */







           /*C# strings start*/

           //strings

           string greeting ="hello huzaifa";
           Console.WriteLine(greeting);

           string greeting2 ="Nice to meet you";
           Console.WriteLine(greeting2);

           string len ="ABCDEFGHIJKLMNOPQRSTUVWXYZ";
           Console.WriteLine("the lenght of string is = " + len.Length);

           string ques ="how are you";
           Console.WriteLine("the length of string id = " + ques.Length);

           string line ="I am fine";
           Console.WriteLine(line.ToUpper());
           Console.WriteLine(line.ToLower());

           //concatenation

           string fname="Muhammad";
           string lname = "Huzaifa";
           string fullnames = fname+lname;
           string names = string.Concat(fname,lname);
           string name1= $"my full name is : {fname} {lname}";

           Console.WriteLine(fullnames);
           Console.WriteLine(fname+lname);
           Console.WriteLine(names);
           Console.WriteLine(name1);

           int numeric =10;
           int numeric1=20;
           Console.WriteLine(numeric+numeric1);

           string txt = "10";
           string txt1 = "20";
           Console.WriteLine(txt+txt1);

           //Access string 

           string myname="Huzaifa";
           Console.WriteLine(myname [0]); 
           Console.WriteLine(myname [1]); 
           Console.WriteLine(myname [2]); 
           Console.WriteLine(myname [3]); 
           Console.WriteLine(myname [4]); 
           Console.WriteLine(myname [5]); 
           Console.WriteLine(myname [6]); 

           Console.WriteLine(myname.IndexOf("a")); 
           Console.WriteLine(myname.IndexOf("z")); 
           Console.WriteLine(myname.IndexOf("i")); 

          string firname= "M_huzaifa";
          int index =firname.IndexOf("h");
          string lasname = firname .Substring(index);

          Console.WriteLine(lasname);

          /*C# strings end*/







          /*start special character 
          in C# from here*/

          string question =" \"Hello Huzaifa\" \'what are you studying\' \\ \'in which standard\'.\n";
          Console.WriteLine(question);

          string answer = " Hi this is Huzaifa,\n I am studing software engineering \t in the 12 staa\bndard.";
          Console.WriteLine(answer);

          /*end special character 
          in C# from here*/








        /*C# booleans start from here.*/

        bool isCSharpFun = true;
        bool isFishTasty = false;
        Console.WriteLine(isCSharpFun);   // Outputs True
        Console.WriteLine(isFishTasty);   // Outputs False

        int val =10;
        int val1 =20;

        Console.WriteLine(val<val1);

        Console.WriteLine(10==10);
        Console.WriteLine(10==15);

        
        /*C# booleans end from here.*/









        /*if or else  in C# 
        examples start from here*/

        int myage=17;
        int hisage=19;

        if(myage <= hisage)
        {
            Console.WriteLine("\nyou are younger than him");
        }

        else {
            Console.WriteLine("\nhe is elder than you");
        }



        //if statement
        int val3=40;
        int val4= 50;

        if(val3 < val4)
        {
            Console.WriteLine("40 is leen than 50");
        }
        else{
            Console.WriteLine("this statement is wrong");
        }




        //if or else both statements.
        int time = 20;
        if (time < 18) 
        {
          Console.WriteLine("Good day.");
        } 
        else 
        {
          Console.WriteLine("Good evening.");
        }



        //if ,else or elseif statment.
        int date =23;
        if (date >25){
            Console.WriteLine("good morning");
        }
        else if (date >22){
            Console.WriteLine("good afternoon");
        }
        else {
            Console.WriteLine("both statement are wrong");
        }



        //short_hand if ,else

        int time1 =25;
        string result =  (time1 <24) ? "good morning" :"good evening";
        Console.WriteLine(result);

        /*if or else  in C# 
        examples end from here*/







        /*switch in C#
        start from here*/
       
        int day =8;
        switch(day)
        {
         case 1 :
         Console.WriteLine("Monday");
         break;
         case 2 :
         Console.WriteLine("tuesday");
         break;
         case 3 :
         Console.WriteLine("wednesday");
         break;
         case 4 :
         Console.WriteLine("thursday");
         break;
         case 5 :
         Console.WriteLine("friday");
         break;
         case 6 :
         Console.WriteLine("saturday");
         break;
         case 7 :
         Console.WriteLine("sunday");
         break;
         default:
         Console.WriteLine("invalid case");
         break;
        }

        /*switch in C#
        end from here*/








        /*Loops in C#
        start from here*/

        //while loop
        int ab =0;
        while (ab <10)
        {
            ab ++;
            Console.WriteLine(ab);
        }


        //do while loop

        int ac =0;
        do{
            Console.WriteLine( "the value is = " +ac);
            ac ++;
        }
        while (ac<10);


        //for loop
    
        for (int za=2 ; za <=10 ; za++)
        {
            Console.WriteLine(za);
        }
        for (int zb=2 ; zb <=100 ; zb =zb+2)
        {
            Console.WriteLine(zb);
        }

        for (int zc=1 ; zc <=100 ; zc =zc+2)
        {
            Console.WriteLine(zc);
        }


        for (int valu=1 ; valu <=2 ; valu ++)
        {
            Console.WriteLine("outer" + valu);

        for(int valu1 = 1; valu1<=4; valu1 ++) 
        {
            Console.WriteLine("\tinner" + valu1);
        }
        }

        //foreach loop

        string [] cars = {"Volvo", "BMW", "Ford", "Mazda"};
        foreach (string ji in cars)
        Console.WriteLine("this is car = " +ji);


        //break and continue in C#

        for(int hu =1; hu<=10 ; hu ++)
        {
            if (hu ==5){
                break;
            }
            Console.WriteLine(hu);
        }


        for(int hu =1; hu<=10 ; hu ++)
        {
            if (hu ==5){
                continue;
            }
            Console.WriteLine(hu);
        }


        int ig =0;
        while(ig < 10){
            ig ++;
            if(ig ==5){
                break;
            }
            Console.WriteLine(ig);
        }

        int ih =0;
        while(ih <10){
             ih ++;
            if(ih ==5){
                continue;
            }
            Console.WriteLine(ih);
        }

        /*Loops in C#
        end from here*/







        /*arrays in C#
        stsrt here*/

        string[] carss ={"Volvo", "BMW", "Ford", "Mazda"};
        carss [1]= "farari";
        Console.WriteLine(carss[2]);
        Console.WriteLine(carss[1]);
        Console.WriteLine(carss[3]);
        Console.WriteLine(carss[0]);

        string[] fruits ={"apple" , "grapes" , "pomegrant" , "gava"};
        Console.WriteLine(fruits[2]);
        Console.WriteLine(fruits[1]);
        Console.WriteLine(fruits[3]);
        Console.WriteLine(fruits[0]);


        Console.WriteLine(carss.Length);
        Console.WriteLine(fruits.Length);

        string[] languages;
        languages = new string[] {"php" , "javascript" , "mysql"};
        Console.WriteLine(languages[1]);


        //loops through array

        string[] animals={"cat" , "lion" , "dog" , "elephant"};
        for(int io =0 ; io<animals.Length ; io ++){
            Console.WriteLine(animals[io]);
        }

        string[] animal={"cat" , "lion" , "dog" , "elephant"};
        foreach(string ip in animal){
            Console.WriteLine(ip);
        }


        //sort arrrays

        int[] numbers={3,7,2,4,1,5,6};
        Array.Sort(numbers);
        foreach(int yt in numbers){
            Console.WriteLine(yt);
        }

        string[] nam ={"huzaifa" , "shakir" , "maaz" , "hamza"};
        Array.Sort(nam);
        foreach(string oy in nam){
            Console.WriteLine(oy);
        }

        Console.WriteLine(numbers.Max());  // returns the largest value
        Console.WriteLine(numbers.Min());  // returns the smallest value
        Console.WriteLine(numbers.Sum());  // returns the sum of elements


        //multidimentional array

        int[,] numers ={{1,2,3},{4,5,6}};
        Console.WriteLine(numers[1 ,2]);
        Console.WriteLine(numers[0 ,1]);
        Console.WriteLine(numers[1 ,0]);

        numers[0,2] = 7;
        Console.WriteLine(numers[0 ,2]);

        int[,] digit ={{3,5,6,},{8,9,2}};
        foreach(int hi in digit){
            Console.WriteLine(hi);
        }

        int[,] digi ={{10,20,30,40},{50,60,70,80}};

        for(int vo = 0 ; vo < digi.GetLength(0); vo++)
        {
               for(int vi = 0 ; vi < digi.GetLength(1); vi++)
               {
                    Console.WriteLine(digi[vo,vi]);
               }
        } 

        /*Loops in C#
        end from here*/

    }

}
           