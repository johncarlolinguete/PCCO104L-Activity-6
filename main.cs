using System;


class Program {

    public static void Main (string[] args) {

        while (true) {

            Console.WriteLine ("Select Activity from 1 - 5: ");

            string choice = Console.ReadLine();

            int choice2 = int.Parse(choice);


            if (choice2 == 6) {

                Console.WriteLine("Exiting Program...");

                break;

            }


            PerformActivity(choice2);

        }

    }


    public static void PerformActivity(int choice2) {

        string moneyface() {

            double value2;

            string exit = "exit";


            do {

                Console.WriteLine("Enter Value: ");

                string value = Console.ReadLine();


                if (value.ToLower() == exit) {

                    Console.WriteLine("Closing Program...");

                    break;

                }


                if (!double.TryParse(value, out value2)) {

                    Console.WriteLine("Invalid input. Please enter a valid number or 'exit' to quit.");

                    continue;

                }


                if (value2 == 0.01 || value2 == 0.05 || value2 == 0.25) {

                    Console.WriteLine($"No person is found in Php {value}");

                } else if (value2 == 1) {

                    Console.WriteLine($"Jose Rizal is found in Php {value}");

                } else if (value2 == 5) {

                    Console.WriteLine($"Emilio Aguinaldo is found in Php {value}");

                } else if (value2 == 10) {

                    Console.WriteLine($"Andres Bonifacio and Apolinario Mabini are found in Php {value}");

                } else if (value2 == 20) {

                    Console.WriteLine($"Manuel L. Quezon is found in Php {value}");

                } else if (value2 == 50) {

                    Console.WriteLine($"Sergio Osmena is found in Php {value}");

                } else if (value2 == 100) {

                    Console.WriteLine($"Manuel Roxas is found in Php {value}");

                } else if (value2 == 200) {

                    Console.WriteLine($"Diosdado Macapagal is found in Php {value}");

                } else if (value2 == 500) {

                    Console.WriteLine($"Benigno Sr. and Corazon Aquino are found in Php {value}");

                } else if (value2 == 1000) {

                    Console.WriteLine($"Jose Abad Santos, Vicente Lim and Josefa Llanes Escoda are found in Php {value}");

                } else {

                    Console.WriteLine($"Invalid Denomination: {value}");

                }

            } while (true);

            return "Exiting Program...";

        }


        string foobar() {

            int num2;

            string exit = "exit";

            do {

                Console.WriteLine("Enter a Value: ");

                string num = Console.ReadLine();

                if (num.ToLower() == exit) {

                    Console.WriteLine("Closing Program...");

                    break;

                }


                if (!int.TryParse(num, out num2)) {

                    Console.WriteLine("Invalid input. Please enter a valid number or 'exit' to quit.");

                    continue;

                } else {

                    for (int i = 1; i <= num2; i++) {

                        if (i % 3 == 0 && i % 5 == 0) {

                            Console.WriteLine($"{i} - FooBar");

                        } else if (i % 3 == 0) {

                            Console.WriteLine($"{i} - Foo");

                        } else if (i % 5 == 0) {

                            Console.WriteLine($"{i} - Bar");

                        } else {

                            Console.WriteLine(i);

                        }

                    }

                }

            } while (true);

            return "Exiting Program...";

        }


        string joinword() {

            string joint = "";

            string word;

            do {

                Console.Write("Enter Something: ");

                word = Console.ReadLine();

                joint += word + " ";

                Console.WriteLine(joint);

            } while (word != "exit");

            Console.WriteLine("Closing Program...");

            return "Exiting Program...";

        }


        string pyramid() {

            int num;

            string exit = "exit";


            do {

                Console.Write ("Enter a Number: ");

                string input = Console.ReadLine();


               if (input.ToLower() == exit) {

                    Console.WriteLine("Closing Program...");

                    break;

               }


                if (!int.TryParse(input, out num) || num < 0) {

                    Console.WriteLine($"Invalid Input: {input} ");

                    continue;

                }



                if (num == 0) break;


                for (int i = 1; i <= num; i++) {

                    for (int j = 1; j <= (num - i); j++)

                        Console.Write(" ");


                    for (int k = 1; k < i * 2; k++)

                        Console.Write("*");


                    Console.WriteLine();

                }

            } while (true);


            Console.WriteLine("Closing Program...");

            return "Exiting Program...";

        }


        string sumappend() {

            int num1 = 0;

            string message = "";


            while (true) {

                Console.Write("Enter Something: ");

                string input = Console.ReadLine();


                if (input.ToLower() == "exit") {

                    Console.WriteLine("Exiting the program...");

                    break;

                }


                int number;

                bool isNumeric = int.TryParse(input, out number);


                if (isNumeric) {

                    int num2 = int.Parse(input);

                    int sum = num1 + num2;

                    Console.WriteLine($"Sum of {num1} and {num2} is {sum}.");

                    num1 = num2;

                } else {

                    message += input + " ";

                    Console.WriteLine("Message so far: " + message);

                }

            }

            return "Exiting Program...";

        }


        switch (choice2) {

            case 1:

                moneyface();

                break;

            case 2:

                foobar();

                break;

            case 3:

                joinword();

                break;

            case 4:

                pyramid();

                break;

            case 5:

                sumappend();

                break;

            default:

                Console.WriteLine("Invalid Input");

                break;

        }

    }

}