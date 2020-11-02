using System;

namespace room_sched_system
{
    class Program
    {
    	//Mainmenuitems.
        static void Main(string[] args){
            const int maxMenuItems = 13;
            int selector = 0;
            bool good = false;
            while (selector != maxMenuItems){
                Console.Clear(); 
                DrawTitle();
                
                DrawMenu(maxMenuItems);
                //user input
                good = int.TryParse(Console.ReadLine(), out selector);
                if (good){
					switch (selector){
                        case 1:
                            DisplayRoom101();
                            break;
                        case 2:
                            DisplayRoom102();
                            break;
                        case 3:
                            DisplayRoom103();
                            break;
                        case 4:
                            DisplayRoom106();
                            break;
                        case 5:
                            DisplayRoom107();
                            break;
                        case 6:
                            DisplayRoom108();
                            break;
                        case 7:
                            DisplayRoom201();
                            break;
                        case 8:
                            DisplayRoom202();
                            break;
                        case 9:
                            DisplayRoom203();
                            break;
                        case 10:
                            DisplayRoom204();
                            break;
                        case 11:
                            DisplayRoom205();
                            break;
                        case 12:
                            DisplayRoom206();
                            break;
                        default:
                            if (selector != maxMenuItems){
                                ErrorMessage();
                            }
                            break;
                    }
                }
                else{
                    ErrorMessage();
                }Console.WriteLine("Press any key...");
                Console.ReadKey();
            }
            }
        private static void ErrorMessage(){
            Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine("Typing error, press key to continue."); Console.ResetColor();
        }
        private static void DrawStarLine(){
            Console.WriteLine("***************************************************************");
        }
        private static void DrawTitle(){
            DrawStarLine();
            DrawStarLine();
            Console.ForegroundColor = ConsoleColor.Green; Console.WriteLine(" +++   CCS LSPU VOAG BUILDING ROOM SCHEDULING INFORMATION   +++"); Console.ResetColor();
            DrawStarLine();
        }
        private static void DrawMenu(int maxitems){
            DrawStarLine();
            Console.WriteLine("[1] = Room 101\n[2] = Room 102\n[3] = Room 103\n[4] = Room 106\n[5] = Room 107\n[6] = Room 108\n[7] = Room 201\n[8] = Room 202\n[9] = Room 203\n[10] = Room 204\n[11] = Room 205\n[12] = Room 206");
            DrawStarLine();
            Console.ForegroundColor = ConsoleColor.DarkGray; Console.WriteLine("\tMake your choice: type 1, 2,... or {0} for exit", maxitems);Console.ResetColor();
            DrawStarLine();
        }

        //ROOM 101 INFO.
        private static void DisplayRoom101(){
            const int maxMenuItems = 7;
            int selector = 0;
            bool good = false;
            while (selector != maxMenuItems){
                Console.Clear();
                DrawStarLine();
                    Console.ForegroundColor = ConsoleColor.Green; Console.WriteLine("\t\t***CCS VOAG ROOM 101 SCHEDULE***"); Console.ResetColor();
                DrawStarLine();
                DrawMenu101(maxMenuItems);
                //user input
                good = int.TryParse(Console.ReadLine(), out selector);
                if (good){
					switch (selector){
                        case 1:
							MonRoom101();
							break;
                        case 2:
                            TueRoom101();
                            break;
                        case 3:
                            WedRoom101();
                            break;
                        case 4:
                            ThuRoom101();
                            break;
                        case 5:
                            FriRoom101();
                            break;
                        case 6:
                            AWRoom101();
                            break;                            
                        default:
                            if (selector != maxMenuItems)
                            { ErrorMessage();
                         } break;
                    }
                }
                else{ ErrorMessage();
                } 
                Console.ReadKey();
            }
            }
            private static void DrawMenu101(int maxitems){ 
            Console.WriteLine("[1] = Monday\n[2] = Tuesday\n[3] = Wednesday\n[4] = Thursday\n[5] = Friday\n[6] = All Week Schedule");
            DrawStarLine();
            Console.ForegroundColor = ConsoleColor.DarkGray; Console.WriteLine("  Make your choice: type 1, 2,... or {0} Go Back to Room Choices", maxitems); Console.ResetColor();
            DrawStarLine();
            }
            private static void MonRoom101(){
            const double MonmaxMenuItems = 25;
            double timeselector = 0;
            bool time = false;
            while (timeselector != MonmaxMenuItems){
                Console.Clear();
                	DrawStarLine();
                    Console.ForegroundColor = ConsoleColor.Green; Console.WriteLine("\t\t\t***MONDAY***"); Console.ResetColor();
                    Console.WriteLine("\tInput Time now in 24 hours(Input 25 to Back): ");
					DrawStarLine();                    
                	time = double.TryParse(Console.ReadLine(), out timeselector);
					Console.Clear();
				if  (timeselector >= 7.5 & timeselector <= 9.5){
					DrawStarLine();
					Console.WriteLine("Period Time: 7:30 - 9:30\nSubject: CT 213 Basic Electronics Circuit 2\nSection & Year: ACT 2-A\nInstructor: Mrs. Joy Adrias");
					DrawStarLine();
					Console.WriteLine("\nEnter to Back...");
                }
				else if (timeselector > 9.5 & timeselector <= 12){
					DrawStarLine();
					Console.WriteLine("Period Time: 9:30 - 12:00\nSubject: CT 122 Basic Electronics Circuit 1\nSection & Year: ACT 1-C\nInstructor: Mrs. Joy Adrias");
					DrawStarLine();
					Console.WriteLine("\nEnter to Back...");
                }
				else if (timeselector >= 13 & timeselector <= 16){
					DrawStarLine();
					Console.WriteLine("Period Time: 1:00 - 5:00\nSubject: CT 212 PC Basic Troubleshooting Maintenance Quality Control & Safety Measure\nSection & Year: ACT 2-A\nInstructor: Mrs. Joy Adrias");
					DrawStarLine();
					Console.WriteLine("\nEnter to Back...");
                }
				else if(timeselector != MonmaxMenuItems){
					Console.WriteLine("NO SCHEDULE ASSIGN/Typing error (Press any key...)");
                            }
                else{
                    Console.WriteLine("Press any key...");
                }
                Console.ReadKey();
            }                    	       	
            }
            private static void TueRoom101(){
            const double MonmaxMenuItems = 25;
            double timeselector = 0;
            bool time = false;
            while (timeselector != MonmaxMenuItems){
                Console.Clear();
                DrawStarLine();
                    	Console.ForegroundColor = ConsoleColor.Green; Console.WriteLine("\t\t\t***TUESDAY***"); Console.ResetColor();
                    	Console.WriteLine("\tInput Time now in 24 hours(Input 25 to Back): "); DrawStarLine();                
                time = double.TryParse(Console.ReadLine(), out timeselector);
                Console.Clear();
				if (timeselector >= 8 && timeselector <= 10){DrawStarLine();
					Console.WriteLine("Period Time: 8:00 - 10:00\nSubject: ITEE 301B Fundamentals of Business Process Outsourcing 1\nSection & Year: BSIT 3-A\nInstructor: Mrs. Joy Adrias");
					DrawStarLine();
					Console.WriteLine("\nEnter to Back...");
                }
				else if (timeselector > 10 && timeselector <= 12){DrawStarLine();
					Console.WriteLine("Period Time: 10:00 - 12:00\nSubject: CT 122 Basic Electronics Circuit 1\nSection & Year: ACT 1-C\nInstructor: Mrs. Joy Adrias");
					DrawStarLine();
					Console.WriteLine("\nEnter to Back...");
                }
				else if (timeselector >= 13 && timeselector <= 14){DrawStarLine();
					Console.WriteLine("Period Time: 1:00 - 2:00\nSubject: CT 212 Basic Electronics Circuit 2\nSection & Year: ACT 2-A\nInstructor: Mrs. Joy Adrias");
					DrawStarLine();
					Console.WriteLine("\nEnter to Back...");
                }
				else if (timeselector != MonmaxMenuItems){
					Console.WriteLine("NO SCHEDULE ASSIGN/Typing error (Press any key...)");
                            }
                else{
                    Console.WriteLine("Press any key...");
                }
                Console.ReadKey();
            }                    	        	
            }
            private static void WedRoom101(){
            const double MonmaxMenuItems = 25;
            double timeselector = 0;
            bool time = false;
            while (timeselector != MonmaxMenuItems){
                Console.Clear();
                	DrawStarLine();
                    Console.ForegroundColor = ConsoleColor.Green; Console.WriteLine("\t\t\t***WEDNESDAY***"); Console.ResetColor();
                    Console.WriteLine("\tInput Time now in 24 hours(Input 25 to Back): ");
					DrawStarLine();                    
                	time = double.TryParse(Console.ReadLine(), out timeselector);
					Console.Clear();
				if  (timeselector >= 7.5 & timeselector <= 10.5){
					DrawStarLine();
					Console.WriteLine("Period Time: 7:30 - 10:30\nSubject: ITEE 301B Fundamentals of Business Process Outsourcing 1 \nSection & Year: BSIT 3-A\nInstructor: Mrs. Joy Adrias");
					DrawStarLine();
					Console.WriteLine("\nEnter to Back...");
                }
				else if (timeselector > 10.5 & timeselector <= 11.5){
					DrawStarLine();
					Console.WriteLine("Period Time: 10:30 - 11:30\nSubject: ITEE 301B\nSection & Year: BSIT 3-A\nInstructor: Mrs. Joy Adrias");
					DrawStarLine();
					Console.WriteLine("\nEnter to Back...");
                }
				else if (timeselector >= 12 & timeselector <= 13){
					DrawStarLine();
					Console.WriteLine("Period Time: 12:00 - 1:00\nSubject: Math 211  \nSection & Year: BSIT 2-A\nInstructor: Mr. E. Benedictos");
					DrawStarLine();
					Console.WriteLine("\nEnter to Back...");
                }
				else if (timeselector >= 14.5 & timeselector <= 15){
					DrawStarLine();
					Console.WriteLine("Period Time: 2:30 - 4:00\nSubject: GEC 102 Reading in Phil. History\nSection & Year: BSIT 1-A\nInstructor: Mr. Lacao-cao");
					DrawStarLine();
					Console.WriteLine("\nEnter to Back...");
                }
				else if(timeselector != MonmaxMenuItems){
					Console.WriteLine("NO SCHEDULE ASSIGN/Typing error (Press any key...)");
                            }
                else{
                    Console.WriteLine("Press any key...");
                }
                Console.ReadKey();
            }                    	         	
            }
            private static void ThuRoom101(){
            const double MonmaxMenuItems = 25;
            double timeselector = 0;
            bool time = false;
            while (timeselector != MonmaxMenuItems){
                Console.Clear();
                	DrawStarLine();
                    Console.ForegroundColor = ConsoleColor.Green; Console.WriteLine("\t\t\t***THURSDAY***"); Console.ResetColor();
                    Console.WriteLine("\tInput Time now in 24 hours(Input 25 to Back): ");
					DrawStarLine();                    
                	time = double.TryParse(Console.ReadLine(), out timeselector);
					Console.Clear();
				if  (timeselector >= 8 & timeselector <= 9.5){
					DrawStarLine();
					Console.WriteLine("Period Time: 8:00 - 9:30\nSubject: SOCS 211 Society & Culture w/ Family Planning\nSection & Year: ACT 2-A\nInstructor: Mrs. J. Caranguian");
					DrawStarLine();
					Console.WriteLine("\nEnter to Back...");
                }
				else if (timeselector >= 10 & timeselector <= 13){
					DrawStarLine();
					Console.WriteLine("Period Time: 10:00 - 1:00\nSubject: SMBUSCO Business Comm. \nSection & Year: ACT 2-A\nInstructor: Mrs. B. Lao Santos");
					DrawStarLine();
					Console.WriteLine("\nEnter to Back...");
                }
				else if (timeselector >= 13.5 & timeselector <= 14){
					DrawStarLine();
					Console.WriteLine("Period Time: 1:30 - 3:00\nSubject: CT 215\nSection & Year: ACT 2-A\nInstructor: Mr. N. Astoveza");
					DrawStarLine();
					Console.WriteLine("\nEnter to Back...");
                }
				else if (timeselector > 14 & timeselector <= 16){
					DrawStarLine();
					Console.WriteLine("Period Time: 3:00 - 5:00\nSubject: ITEC 101\nSection & Year: BSIT 1-E\nInstructor: Mr. N. Astoveza");
					DrawStarLine();
					Console.WriteLine("\nEnter to Back...");
                }
				else if(timeselector != MonmaxMenuItems){
					Console.WriteLine("NO SCHEDULE ASSIGN/Typing error (Press any key...)");
                            }
                else{
                    Console.WriteLine("Press any key...");
                }
                Console.ReadKey();
            }                    	      	
            }
            private static void FriRoom101()
            {
            const double MonmaxMenuItems = 25;
            double timeselector = 0;
            bool time = false;
            while (timeselector != MonmaxMenuItems){
                Console.Clear();
                	DrawStarLine();
                    Console.ForegroundColor = ConsoleColor.Green; Console.WriteLine("\t\t\t***FRIDAY***"); Console.ResetColor();
                    Console.WriteLine("\tInput Time now in 24 hours(Input 25 to Back): ");
					DrawStarLine();                    
                	time = double.TryParse(Console.ReadLine(), out timeselector);
					Console.Clear();
				if  (timeselector >= 10 & timeselector <= 11.5){
					DrawStarLine();
					Console.WriteLine("Period Time: 10:00 - 11:30\nSubject: FILI 121 Pagbasa at Pagsulat Tungo sa Pananaliksik\nSection & Year: ACT 1-C\nInstructor: Ms. Abulon");
					DrawStarLine();
					Console.WriteLine("\nEnter to Back...");
                }
				else if (timeselector >= 15 & timeselector <= 16){
					DrawStarLine();
					Console.WriteLine("Period Time: 3:00 - 5:00\nSubject: CT 122 Basic Electronics Circuit 1\nSection & Year: ACT 1-C\nInstructor: Mrs. Joy Adrias");
					DrawStarLine();
					Console.WriteLine("\nEnter to Back...");
                }
				else if(timeselector != MonmaxMenuItems){
					Console.WriteLine("NO SCHEDULE ASSIGN/Typing error (Press any key...)");
                            }
                else{
                    Console.WriteLine("Press any key...");
                }
                Console.ReadKey();
            }                    	
                    	
            }
            private static void AWRoom101(){
            Console.Clear();
            DrawStarLine();
            Console.ForegroundColor = ConsoleColor.Green; Console.WriteLine("\t\t**********CCS VOAG ROOM 101 ALL WEEK SCHEDULE**********\n"); Console.ResetColor();
			Console.WriteLine("\tMONDAY\nPeriod Time: 7:30 - 9:30\nSubject: CT 213 Basic Electronics Circuit 2\nSection & Year: ACT 2-A\nInstructor: Mrs. Joy Adrias\nPeriod Time: 9:30 - 12:00\nSubject: CT 122 Basic Electronics Circuit 1\nSection & Year: ACT 1-C\nInstructor: Mrs. Joy Adrias\nPeriod Time: 1:00 - 5:00\nSubject: CT 212 PC Basic Troubleshooting Maintenance Quality Control & Safety Measure\nSection & Year: ACT 2-A\nInstructor: Mrs. Joy AdriasPeriod Time: 1:00 - 5:00\nSubject: CT 212 PC Basic Troubleshooting Maintenance Quality Control & Safety Measure\nSection & Year: ACT 2-A\nInstructor: Mrs. Joy Adrias");
			DrawStarLine();
			Console.WriteLine("\tTUESDAY\nPeriod Time: 8:00 - 10:00\nSubject: ITEE 301B Fundamentals of Business Process Outsourcing 1\nSection & Year: BSIT 3-A\nInstructor: Mrs. Joy Adrias\nPeriod Time: 10:00 - 12:00\nSubject: CT 122 Basic Electronics Circuit 1\nSection & Year: ACT 1-C\nInstructor: Mrs. Joy Adrias\nPeriod Time: 1:00 - 2:00\nSubject: CT 212 Basic Electronics Circuit 2\nSection & Year: ACT 2-A\nInstructor: Mrs. Joy Adrias");
			DrawStarLine();
			Console.WriteLine("\tWEDNESDAY\nPeriod Time: 7:30 - 10:30\nSubject: ITEE 301B Fundamentals of Business Process Outsourcing 1 \nSection & Year: BSIT 3-A\nInstructor: Mrs. Joy Adrias\nPeriod Time: 10:30 - 11:30\nSubject: ITEE 301B\nSection & Year: BSIT 3-A\nInstructor: Mrs. Joy Adrias\nPeriod Time: 12:00 - 1:00\nSubject: Math 211  \nSection & Year: BSIT 2-A\nInstructor: Mr. E. Benedictos\nPeriod Time: 2:30 - 4:00\nSubject: GEC 102 Reading in Phil. History\nSection & Year: BSIT 1-A\nInstructor: Mr. Lacao-cao");
			DrawStarLine();
			Console.WriteLine("\tTHURSDAY\nPeriod Time: 8:00 - 9:30\nSubject: SOCS 211 Society & Culture w/ Family Planning\nSection & Year: ACT 2-A\nInstructor: Mrs. J. Caranguian\nPeriod Time: 10:00 - 1:00\nSubject: SMBUSCO Business Comm. \nSection & Year: ACT 2-A\nInstructor: Mrs. B. Lao Santos\nPeriod Time: 1:30 - 3:00\nSubject: CT 215\nSection & Year: ACT 2-A\nInstructor: Mr. N. Astoveza\nPeriod Time: 3:00 - 5:00\nSubject: ITEC 101\nSection & Year: BSIT 1-E\nInstructor: Mr. N. Astoveza");
			DrawStarLine();
			Console.WriteLine("\tFRIDAY\nPeriod Time: 10:00 - 11:30\nSubject: FILI 121 Pagbasa at Pagsulat Tungo sa Pananaliksik\nSection & Year: ACT 1-C\nInstructor: Ms. Abulon\nPeriod Time: 3:00 - 5:00\nSubject: CT 122 Basic Electronics Circuit 1\nSection & Year: ACT 1-C\nInstructor: Mrs. Joy Adrias");
            DrawStarLine();
            Console.WriteLine("\nPress any key..");
            }
        //ROOM 102 INFO.
        private static void DisplayRoom102(){
            const int maxMenuItems = 7;
            int selector = 0;
            bool good = false;
            while (selector != maxMenuItems){
                Console.Clear();
                DrawStarLine();
                    Console.ForegroundColor = ConsoleColor.Green; Console.WriteLine("\t\t***CCS VOAG ROOM 102 SCHEDULE***"); Console.ResetColor();
                DrawStarLine();
                DrawMenu102(maxMenuItems);
                //user input
                good = int.TryParse(Console.ReadLine(), out selector);
                if (good){
					switch (selector){
                        case 1:
							MonRoom102();
							break;
                        case 2:
                            TueRoom102();
                            break;
                        case 3:
                            WedRoom102();
                            break;
                        case 4:
                            ThuRoom102();
                            break;
                        case 5:
                            FriRoom102();
                            break;
                        case 6:
                            AWRoom102();
                            break;                            
                        default:
                            if (selector != maxMenuItems)
                            { ErrorMessage();
                         } break;
                    }
                }
                else
                { ErrorMessage();
                } Console.ReadKey();
            }
            }
            private static void DrawMenu102(int maxitems){ 
            Console.WriteLine("[1] = Monday\n[2] = Tuesday\n[3] = Wednesday\n[4] = Thursday\n[5] = Friday\n[6] = All Week Schedule");
            DrawStarLine();
            Console.ForegroundColor = ConsoleColor.DarkGray; Console.WriteLine("  Make your choice: type 1, 2,... or {0} Go Back to Room Choices", maxitems); Console.ResetColor();
            DrawStarLine();
            }
            private static void MonRoom102(){
            const double MonmaxMenuItems = 25;
            double timeselector = 0;
            bool time = false;
            while (timeselector != MonmaxMenuItems){
                Console.Clear();
                	DrawStarLine();
                    Console.ForegroundColor = ConsoleColor.Green; Console.WriteLine("\t\t\t***MONDAY***"); Console.ResetColor();
                    Console.WriteLine("\tInput Time now in 24 hours(Input 25 to Back): ");
					DrawStarLine();                    
                	time = double.TryParse(Console.ReadLine(), out timeselector);
					Console.Clear();
				if  (timeselector >= 7 & timeselector <= 8.5){
					DrawStarLine();
					Console.WriteLine("Period Time: 7:00 - 8:30\nSubject: KOMFIL 101\nSection & Year: BSIT 1-B\nInstructor: Mrs. Sancon");
					DrawStarLine();
					Console.WriteLine("\nEnter to Back...");
                }
				else if (timeselector > 10 & timeselector <= 11.5){
					DrawStarLine();
					Console.WriteLine("Period Time: 10:00 - 11:30\nSubject: KOMFIL 101\nSection & Year: BSIS 1-A\nInstructor: Mrs. Sancon");
					DrawStarLine();
					Console.WriteLine("\nEnter to Back...");
                }
				else if (timeselector >= 13 & timeselector <= 14.5){
					DrawStarLine();
					Console.WriteLine("Period Time: 1:00 - 2:30\nSubject: KOMFIL 101\nSection & Year: BSCS 1-A\nInstructor: Ms. Abulon");
					DrawStarLine();
					Console.WriteLine("\nEnter to Back...");
                }
				else if (timeselector > 14.5 & timeselector <= 16){
					DrawStarLine();
				Console.WriteLine("Period Time: 2:30 - 4:00\nSubject: GEC 101 UTS\nSection & Year: BSCS 1-A\nInstructor: Ms. Leopando");
					DrawStarLine();
					Console.WriteLine("\nEnter to Back...");
					}
				else if (timeselector > 16 & timeselector <= 17){
					DrawStarLine();
				Console.WriteLine("Period Time: 4:00 - 5:00\nSubject: GEC 103\nSection & Year: BSIT 1-C\nInstructor: Mr. Marjolino");
					DrawStarLine();
					Console.WriteLine("\nEnter to Back...");
					}
				else if(timeselector != MonmaxMenuItems){
					Console.WriteLine("NO SCHEDULE ASSIGN/Typing error (Press any key...)");
                            }
                else{
                    Console.WriteLine("Press any key...");
                }
                Console.ReadKey();
            }                    	       	
            }
            private static void TueRoom102(){
            const double MonmaxMenuItems = 25;
            double timeselector = 0;
            bool time = false;
            while (timeselector != MonmaxMenuItems){
                Console.Clear();
                DrawStarLine();
                    	Console.ForegroundColor = ConsoleColor.Green; Console.WriteLine("\t\t\t***TUESDAY***"); Console.ResetColor();
                    	Console.WriteLine("\tInput Time now in 24 hours(Input 25 to Back): "); DrawStarLine();
                time = double.TryParse(Console.ReadLine(), out timeselector);
                Console.Clear();
				if (timeselector >= 7.5 && timeselector <= 8.5){DrawStarLine();
					Console.WriteLine("Period Time: 7:00 - 8:30\nSubject: GEC 101 UTS\nSection & Year: BSIT 1-C\nInstructor: Mr. Acorda");
					DrawStarLine();
					Console.WriteLine("\nEnter to Back...");
                }
				else if (timeselector > 8.5 && timeselector <= 9.5){DrawStarLine();
					Console.WriteLine("Period Time: 8:30 - 9:30\nSubject: GEC 102\nSection & Year:BSIT 1-C\nInstructor: Ms. San Roque");
					DrawStarLine();
					Console.WriteLine("\nEnter to Back...");
                }
				else if (timeselector > 9.5 && timeselector <= 11){DrawStarLine();
					Console.WriteLine("Period Time: 9:30 - 11:00\nSubject: PI 101 Life & Works of Rizal\nSection & Year: BSCS 1-A\nInstructor: Mr. Ferrer");
					DrawStarLine();
					Console.WriteLine("\nEnter to Back...");
                }
				else if (timeselector >= 11.5 & timeselector <= 13){
					DrawStarLine();
				Console.WriteLine("Period Time: 11:30 - 1:00\nSubject: ENGLISH 311\nSection & Year:BSIT 3-C\nInstructor: ");
					DrawStarLine();
					Console.WriteLine("\nEnter to Back...");
					}
				else if (timeselector >= 13 & timeselector <= 14.5){
					DrawStarLine();
				Console.WriteLine("Period Time: 1:00 - 2:30\nSubject: KOMFIL 101\nSection & Year: BSCS 1-A\nInstructor: Ms. Abulon");
					DrawStarLine();
					Console.WriteLine("\nEnter to Back...");
					}
				else if (timeselector > 14.5 & timeselector <= 16){
					DrawStarLine();
				Console.WriteLine("Period Time: 2:30 - 4:00\nSubject: GEC 101 UTS\nSection & Year: BSIT 1-A\nInstructor: Ms. Leopando");
					DrawStarLine();
					Console.WriteLine("\nEnter to Back...");
					}
				else if (timeselector > 16 & timeselector <= 17){
					DrawStarLine();
				Console.WriteLine("Period Time: 4:00 - 5:00\nSubject: GEC 103\nSection & Year:BSIT 1-C\nInstructor: Mr. Marjolino");
					DrawStarLine();
					Console.WriteLine("\nEnter to Back...");
					}
				else if (timeselector != MonmaxMenuItems){
					Console.WriteLine("NO SCHEDULE ASSIGN/Typing error (Press any key...)");
                            }
                else{
                    Console.WriteLine("Press any key...");
                }
                Console.ReadKey();
            }                    	        	
            }
            private static void WedRoom102(){
            const double MonmaxMenuItems = 25;
            double timeselector = 0;
            bool time = false;
            while (timeselector != MonmaxMenuItems){
                Console.Clear();
                	DrawStarLine();
                    Console.ForegroundColor = ConsoleColor.Green; Console.WriteLine("\t\t\t***WEDNESDAY***"); Console.ResetColor();
                    Console.WriteLine("\tInput Time now in 24 hours(Input 25 to Back): ");
					DrawStarLine();                    
                	time = double.TryParse(Console.ReadLine(), out timeselector);
					Console.Clear();
				if  (timeselector >= 7 & timeselector <= 8.5){
					DrawStarLine();
					Console.WriteLine("Period Time: 7:00 - 8:30\nSubject: KOMFIL 101\nSection & Year: BSIT 1-B\nInstructor: Mrs. Sancon");
					DrawStarLine();
					Console.WriteLine("\nEnter to Back...");
                }
				else if (timeselector > 10 & timeselector <= 11.5){
					DrawStarLine();
					Console.WriteLine("Period Time: 10:00 - 11:30\nSubject: KOMFIL 101\nSection & Year: BSIS 1-A\nInstructor: Ms. Leopando");
					DrawStarLine();
					Console.WriteLine("\nEnter to Back...");
                }
				else if (timeselector >= 13 & timeselector <= 14.5){
					DrawStarLine();
					Console.WriteLine("Period Time: 1:00 - 2:30\nSubject: GEC 101 UTS\nSection & Year: BSCS 1-A\nInstructor: Ms. Abulon");
					DrawStarLine();
					Console.WriteLine("\nEnter to Back...");
                }
				else if (timeselector > 14.5 & timeselector <= 16){
					DrawStarLine();
				Console.WriteLine("Period Time: 2:30 - 4:00\nSubject: GEC 101 UTS\nSection & Year: BSCS 1-A\nInstructor: Ms. Leopando");
					DrawStarLine();
					Console.WriteLine("\nEnter to Back...");
					}
				else if (timeselector > 16 & timeselector <= 17){
					DrawStarLine();
				Console.WriteLine("Period Time: 4:00 - 5:00\nSubject: GEC 103\nSection & Year: BSIT 1-C\nInstructor: Mr. Marjolino");
					DrawStarLine();
					Console.WriteLine("\nEnter to Back...");
					}
				else if(timeselector != MonmaxMenuItems){
					Console.WriteLine("NO SCHEDULE ASSIGN/Typing error (Press any key...)");
					}
                else{
                    Console.WriteLine("Press any key...");
                }
                Console.ReadKey();
            }                    	         	
            }
            private static void ThuRoom102(){
            const double MonmaxMenuItems = 25;
            double timeselector = 0;
            bool time = false;
            while (timeselector != MonmaxMenuItems){
                Console.Clear();
                	DrawStarLine();
                    Console.ForegroundColor = ConsoleColor.Green; Console.WriteLine("\t\t\t***THURSDAY***"); Console.ResetColor();
                    Console.WriteLine("\tInput Time now in 24 hours(Input 25 to Back): ");
					DrawStarLine();                    
                	time = double.TryParse(Console.ReadLine(), out timeselector);
					Console.Clear();
				if  (timeselector >= 7.5 & timeselector <= 9){
					DrawStarLine();
					Console.WriteLine("Period Time: 7:30 - 9:00\nSubject: GEC 101 UTS\nSection & Year: BSIT 1-C\nInstructor: Mr. Acorda");
					DrawStarLine();
					Console.WriteLine("\nEnter to Back...");
                }
				else if (timeselector >= 9.5 & timeselector <= 11){
					DrawStarLine();
					Console.WriteLine("Period Time: 9:30 - 11:00\nSubject: PI 101 Life & Works of Rizal\nSection & Year: BSCS 1-A\nInstructor: Mr. Ferrer");
					DrawStarLine();
					Console.WriteLine("\nEnter to Back...");
                }
				else if (timeselector >= 11.5 & timeselector <= 13){
					DrawStarLine();
					Console.WriteLine("Period Time: 11:30 - 1:00\nSubject: ENGLISH 311\nSection & Year:BSIT 3-C\nInstructor: ");
					DrawStarLine();
					Console.WriteLine("\nEnter to Back...");
                }
				else if (timeselector > 14.5 & timeselector <= 16){
					DrawStarLine();
					Console.WriteLine("Period Time: 2:30 - 4:00\nSubject: GEC 101 UTS\nSection & Year: BSIT 1-A\nInstructor: Ms. Leopando");
					DrawStarLine();
					Console.WriteLine("\nEnter to Back...");
                }
				else if(timeselector != MonmaxMenuItems){
					Console.WriteLine("NO SCHEDULE ASSIGN/Typing error (Press any key...)");
                            }
                else{
                    Console.WriteLine("Press any key...");
                }
                Console.ReadKey();
            }                    	      	
            }
            private static void FriRoom102()
            {
            const double MonmaxMenuItems = 25;
            double timeselector = 0;
            bool time = false;
            while (timeselector != MonmaxMenuItems){
                Console.Clear();
                	DrawStarLine();
                    Console.ForegroundColor = ConsoleColor.Green; Console.WriteLine("\t\t\t***FRIDAY***"); Console.ResetColor();
                    Console.WriteLine("\tInput Time now in 24 hours(Input 25 to Back): ");
					DrawStarLine();                    
                	time = double.TryParse(Console.ReadLine(), out timeselector);
					Console.Clear();
				if  (timeselector >= 7.5 & timeselector <= 9){
					DrawStarLine();
					Console.WriteLine("Period Time: 7:30 - 9:00\nSubject: GEC 101 UTS\nSection & Year: BSIT 1-D\nInstructor: Mr. Acorda");
					DrawStarLine();
					Console.WriteLine("\nEnter to Back...");
                }
				else if (timeselector >= 11.5 & timeselector <= 12.5){
					DrawStarLine();
					Console.WriteLine("Period Time: 11:30 - 12:30\nSubject: ENGLISH 121\nSection & Year: ACT 1-C\nInstructor: Ms. Carbungeo");
					DrawStarLine();
					Console.WriteLine("\nEnter to Back...");
                }
				else if (timeselector >= 14 & timeselector <= 17){
					DrawStarLine();
				Console.WriteLine("Period Time: 2:00 - 5:00\nSubject: GEC 104 Math in the Modern World\nSection & Year: BSIT 1-A\nInstructor: Mrs. L. Castro");
					DrawStarLine();
					Console.WriteLine("\nEnter to Back...");
					}
				else if(timeselector != MonmaxMenuItems){
					Console.WriteLine("NO SCHEDULE ASSIGN/Typing error (Press any key...)");
                            }
                else{
                    Console.WriteLine("Press any key...");
                }
                Console.ReadKey();
            }                    	
                    	
            }
            private static void AWRoom102(){
            Console.Clear();
            DrawStarLine();
            Console.ForegroundColor = ConsoleColor.Green; Console.WriteLine("\t\t**********CCS VOAG ROOM 102 ALL WEEK SCHEDULE**********\n"); Console.ResetColor();
			Console.WriteLine("\tMONDAY\nPeriod Time: 7:00 - 8:30\nSubject: KOMFIL 101\nSection & Year: BSIT 1-B\nInstructor: Mrs. Sancon\nPeriod Time: 10:00 - 11:30\nSubject: KOMFIL 101\nSection & Year: BSIS 1-A\nInstructor: Mrs. Sancon\nPeriod Time: 1:00 - 2:30\nSubject: KOMFIL 101\nSection & Year: BSCS 1-A\nInstructor: Ms. Abulon\nPeriod Time: 2:30 - 4:00\nSubject: GEC 101 UTS\nSection & Year: BSCS 1-A\nInstructor: Ms. Leopando\nPeriod Time: 4:00 - 5:00\nSubject: GEC 103\nSection & Year: BSIT 1-C\nInstructor: Mr. Marjolino");
			DrawStarLine();
			Console.WriteLine("\tTUESDAY\nPeriod Time: 7:00 - 8:30\nSubject: GEC 101 UTS\nSection & Year: BSIT 1-C\nInstructor: Mr. Acorda\nPeriod Time: 8:30 - 9:30\nSubject: GEC 102\nSection & Year:BSIT 1-C\nInstructor: Ms. San Roque\nPeriod Time: 9:30 - 11:00\nSubject: PI 101 Life & Works of Rizal\nSection & Year: BSCS 1-A\nInstructor: Mr. Ferrer\nPeriod Time: 11:30 - 1:00\nSubject: ENGLISH 311\nSection & Year:BSIT 3-C\nInstructor: \nPeriod Time: 1:00 - 2:30\nSubject: KOMFIL 101\nSection & Year: BSCS 1-A\nInstructor: Ms. Abulon\nPeriod Time: 2:30 - 4:00\nSubject: GEC 101 UTS\nSection & Year: BSIT 1-A\nInstructor: Ms. Leopando\nPeriod Time: 4:00 - 5:00\nSubject: GEC 103\nSection & Year:BSIT 1-C\nInstructor: Mr. Marjolino");
			DrawStarLine();
			Console.WriteLine("\tWEDNESDAY\nPeriod Time: 7:00 - 8:30\nSubject: KOMFIL 101\nSection & Year: BSIT 1-B\nInstructor: Mrs. Sancon\nPeriod Time: 10:00 - 11:30\nSubject: KOMFIL 101\nSection & Year: BSIS 1-A\nInstructor: Ms. Leopando\nPeriod Time: 1:00 - 2:30\nSubject: GEC 101 UTS\nSection & Year: BSCS 1-A\nInstructor: Ms. Abulon\nPeriod Time: 2:30 - 4:00\nSubject: GEC 101 UTS\nSection & Year: BSCS 1-A\nInstructor: Ms. Leopando\nPeriod Time: 4:00 - 5:00\nSubject: GEC 103\nSection & Year: BSIT 1-C\nInstructor: Mr. Marjolino");
			DrawStarLine();
			Console.WriteLine("\tTHURSDAY\nPeriod Time: 7:30 - 9:00\nSubject: GEC 101 UTS\nSection & Year: BSIT 1-C\nInstructor: Mr. Acorda\nPeriod Time: 9:30 - 11:00\nSubject: PI 101 Life & Works of Rizal\nSection & Year: BSCS 1-A\nInstructor: Mr. Ferrer\nPeriod Time: 11:30 - 1:00\nSubject: ENGLISH 311\nSection & Year:BSIT 3-C\nInstructor: \nPeriod Time: 2:30 - 4:00\nSubject: GEC 101 UTS\nSection & Year: BSIT 1-A\nInstructor: Ms. Leopando");
			DrawStarLine();
			Console.WriteLine("\tFRIDAY\nPeriod Time: 7:30 - 9:00\nSubject: GEC 101 UTS\nSection & Year: BSIT 1-D\nInstructor: Mr. Acorda\nPeriod Time: 11:30 - 12:30\nSubject: ENGLISH 121\nSection & Year: ACT 1-C\nInstructor: Ms. Carbungeo\nPeriod Time: 2:00 - 5:00\nSubject: GEC 104 Math in the Modern World\nSection & Year: BSIT 1-A\nInstructor: Mrs. L. Castro");
            DrawStarLine();
            Console.WriteLine("\nPress any key..");
            }
        //ROOM 103 INFO.
        private static void DisplayRoom103(){
            const int maxMenuItems = 7;
            int selector = 0;
            bool good = false;
            while (selector != maxMenuItems){
                Console.Clear();
                DrawStarLine();
                    Console.ForegroundColor = ConsoleColor.Green; Console.WriteLine("\t\t***CCS VOAG ROOM 103 SCHEDULE***"); Console.ResetColor();
                DrawStarLine();
                DrawMenu103(maxMenuItems);
                //user input
                good = int.TryParse(Console.ReadLine(), out selector);
                if (good){
					switch (selector){
                        case 1:
							MonRoom103();
							break;
                        case 2:
                            TueRoom103();
                            break;
                        case 3:
                            WedRoom103();
                            break;
                        case 4:
                            ThuRoom103();
                            break;
                        case 5:
                            FriRoom103();
                            break;
                        case 6:
                            AWRoom103();
                            break;                            
                        default:
                            if (selector != maxMenuItems)
                            { ErrorMessage();
                         } break;
                    }
                }
                else
                { ErrorMessage();
                } Console.ReadKey();
            }
            }
            private static void DrawMenu103(int maxitems){ 
            Console.WriteLine("[1] = Monday\n[2] = Tuesday\n[3] = Wednesday\n[4] = Thursday\n[5] = Friday\n[6] = All Week Schedule");
            DrawStarLine();
            Console.ForegroundColor = ConsoleColor.DarkGray; Console.WriteLine("  Make your choice: type 1, 2,... or {0} Go Back to Room Choices", maxitems); Console.ResetColor();
            DrawStarLine();
            }
            private static void MonRoom103(){
            const double MonmaxMenuItems = 25;
            double timeselector = 0;
            bool time = false;
            while (timeselector != MonmaxMenuItems){
                Console.Clear();
                	DrawStarLine();
                    Console.ForegroundColor = ConsoleColor.Green; Console.WriteLine("\t\t\t***MONDAY***"); Console.ResetColor();
                    Console.WriteLine("\tInput Time now in 24 hours(Input 25 to Back): ");
					DrawStarLine();                    
                	time = double.TryParse(Console.ReadLine(), out timeselector);
					Console.Clear();
				if  (timeselector >= 8 & timeselector <= 9.5){
					DrawStarLine();
					Console.WriteLine("Period Time: 8:00 - 9:30\nSubject: ENGL 121 Comm. for IT\nSection & Year: ACT 1-C\nInstructor: Mrs. Fernandez");
					DrawStarLine();
					Console.WriteLine("\nEnter to Back...");
                }
				else if (timeselector > 9.5 & timeselector <= 10){
					DrawStarLine();
					Console.WriteLine("Period Time: 9:30 - 10:00\nSubject: ICT 1\nSection & Year: 1-B\nInstructor: Mr. De Jesus");
					DrawStarLine();
					Console.WriteLine("\nEnter to Back...");
                }
				else if (timeselector >= 10.5 & timeselector <= 12){
					DrawStarLine();
					Console.WriteLine("Period Time: 10:30 - 12:00\nSubject: SOCS 3 Politics & Gov. in Phil. Cons.\nSection & Year: BSIT 3-B/3-C\nInstructor: Mr. Lacao-cao");
					DrawStarLine();
					Console.WriteLine("\nEnter to Back...");
                }
				else if (timeselector >= 13 & timeselector <= 14.5){
					DrawStarLine();
				Console.WriteLine("Period Time: 1:00 - 2:30\nSubject: ITEP 208 Service Culture\nSection & Year: BSIT 3-C\nInstructor: Mr. F. Balahadia");
					DrawStarLine();
					Console.WriteLine("\nEnter to Back...");
					}
				else if (timeselector >= 16 & timeselector <= 17){
					DrawStarLine();
				Console.WriteLine("Period Time: 4:00 - 5:00\nSubject: MATH 121\nSection & Year: ACT 1-C\nInstructor: Mr. I. Castro");
					DrawStarLine();
					Console.WriteLine("\nEnter to Back...");
					}
				else if(timeselector != MonmaxMenuItems){
					Console.WriteLine("NO SCHEDULE ASSIGN/Typing error (Press any key...)");
                            }
                else{
                    Console.WriteLine("Press any key...");
                }
                Console.ReadKey();
            }                    	       	
            }
            private static void TueRoom103(){
            const double MonmaxMenuItems = 25;
            double timeselector = 0;
            bool time = false;
            while (timeselector != MonmaxMenuItems){
                Console.Clear();
                DrawStarLine();
                    	Console.ForegroundColor = ConsoleColor.Green; Console.WriteLine("\t\t\t***TUESDAY***"); Console.ResetColor();
                    	Console.WriteLine("\tInput Time now in 24 hours(Input 25 to Back): "); DrawStarLine();
                time = double.TryParse(Console.ReadLine(), out timeselector);
                Console.Clear();
				if (timeselector >= 8 && timeselector <= 9.5){DrawStarLine();
					Console.WriteLine("Period Time: 8:00 - 9:30\nSubject: PI 100 Life & Works of Rizal\nSection & Year: ACT 1-C\nInstructor: Mr. Lacao-cao");
					DrawStarLine();
					Console.WriteLine("\nEnter to Back...");
                }
				else if (timeselector > 9.5 && timeselector <= 11){DrawStarLine();
					Console.WriteLine("Period Time: 9:30 - 11:00\nSubject: MATH 221 Probabilities of Statistics\nSection & Year: ACT 2-A\nInstructor: E. Benedictos");
					DrawStarLine();
					Console.WriteLine("\nEnter to Back...");
                }
				else if (timeselector >= 11 && timeselector <= 12){DrawStarLine();
					Console.WriteLine("Period Time: 11:00 - 12:00\nSubject: CT 214 Database System\nSection & Year: ACT 2-A\nInstructor: Mr. Astoveza");
					DrawStarLine();
					Console.WriteLine("\nEnter to Back...");
                }
				else if (timeselector >= 12.5 & timeselector <= 14.5){
					DrawStarLine();
				Console.WriteLine("Period Time: 12:30 - 2:30\nSubject: PHYS 121\nSection & Year: ACT 1-C\nInstructor: Mr. E. Serrano");
					DrawStarLine();
					Console.WriteLine("\nEnter to Back...");
					}
				else if (timeselector > 14.5 & timeselector <= 16){
					DrawStarLine();
				Console.WriteLine("Period Time: 2:30 - 4:00\nSubject: GEC 102 Reading in Phil. History\nSection & Year: BSIT 1-B\nInstructor: Mr. Lacao-cao");
					DrawStarLine();
					Console.WriteLine("\nEnter to Back...");
					}
				else if (timeselector != MonmaxMenuItems){
					Console.WriteLine("NO SCHEDULE ASSIGN/Typing error (Press any key...)");
                            }
                else{
                    Console.WriteLine("Press any key...");
                }
                Console.ReadKey();
            }                    	        	
            }
            private static void WedRoom103(){
            const double MonmaxMenuItems = 25;
            double timeselector = 0;
            bool time = false;
            while (timeselector != MonmaxMenuItems){
                Console.Clear();
                	DrawStarLine();
                    Console.ForegroundColor = ConsoleColor.Green; Console.WriteLine("\t\t\t***WEDNESDAY***"); Console.ResetColor();
                    Console.WriteLine("\tInput Time now in 24 hours(Input 25 to Back): ");
					DrawStarLine();                    
                	time = double.TryParse(Console.ReadLine(), out timeselector);
					Console.Clear();
				if  (timeselector >= 9.5 & timeselector <= 11){
					DrawStarLine();
					Console.WriteLine("Period Time: 9:30 - 11:00\nSubject: MATH 221 Probabilities of Statistics\nSection & Year: ACT 2-A\nInstructor: E. Benedictos");
					DrawStarLine();
					Console.WriteLine("\nEnter to Back...");
                }
				else if (timeselector > 12.5 & timeselector <= 16){
					DrawStarLine();
					Console.WriteLine("Period Time: 12:30 - 4:00\nSubject: PHYS 121\nSection & Year: ACT 1-C\nInstructor: Mr. E. Serrano");
					DrawStarLine();
					Console.WriteLine("\nEnter to Back...");
                }
				else if (timeselector > 16 & timeselector <= 17){
					DrawStarLine();
					Console.WriteLine("Period Time: 4:00 - 5:00\nSubject: MATH 121\nSection & Year: ACT 1-C\nInstructor: Mr. I. Castro");
					DrawStarLine();
					Console.WriteLine("\nEnter to Back...");
                }
				else if(timeselector != MonmaxMenuItems){
					Console.WriteLine("NO SCHEDULE ASSIGN/Typing error (Press any key...)");
                            }
                else{
                    Console.WriteLine("Press any key...");
                }
                Console.ReadKey();
            }                    	         	
            }
            private static void ThuRoom103(){
            const double MonmaxMenuItems = 25;
            double timeselector = 0;
            bool time = false;
            while (timeselector != MonmaxMenuItems){
                Console.Clear();
                	DrawStarLine();
                    Console.ForegroundColor = ConsoleColor.Green; Console.WriteLine("\t\t\t***THURSDAY***"); Console.ResetColor();
                    Console.WriteLine("\tInput Time now in 24 hours(Input 25 to Back): ");
					DrawStarLine();                    
                	time = double.TryParse(Console.ReadLine(), out timeselector);
					Console.Clear();
				if  (timeselector >= 7.5 & timeselector <= 9){
					DrawStarLine();
					Console.WriteLine("Period Time: 7:30 - 9:00\nSubject: PI 100 Life & Works of Rizal\nSection & Year: ACT 1-C\nInstructor: Mr. Lacao-cao");
					DrawStarLine();
					Console.WriteLine("\nEnter to Back...");
                }
				else if (timeselector > 9 & timeselector <= 11){
					DrawStarLine();
					Console.WriteLine("Period Time: 9:00 - 11:00\nSubject: GEC 102 Reading in Phil. History\nSection & Year: BSIT 1-C\nInstructor:  Ms. San Roque");
					DrawStarLine();
					Console.WriteLine("\nEnter to Back...");
                }
				else if (timeselector >= 11 & timeselector <= 12){
					DrawStarLine();
					Console.WriteLine("Period Time: 11:00 - 12:00\nSubject: MATH 121\nSection & Year: ACT 1-C\nInstructor: Mr. I. Castro");
					DrawStarLine();
					Console.WriteLine("\nEnter to Back...");
                }
				else if (timeselector > 14.5 & timeselector <= 16){
					DrawStarLine();
					Console.WriteLine("Period Time: 2:30 - 4:00\nSubject: FILI 121 Pagbasa at Pagsulat Tungo sa Pananaliksik\nSection & Year: ACT 1-C\nInstructor: Ms. Abulon");
					DrawStarLine();
					Console.WriteLine("\nEnter to Back...");
                }
				else if(timeselector != MonmaxMenuItems){
					Console.WriteLine("NO SCHEDULE ASSIGN/Typing error (Press any key...)");
                            }
                else{
                    Console.WriteLine("Press any key...");
                }
                Console.ReadKey();
            }                    	      	
            }
            private static void FriRoom103()
            {
            const double MonmaxMenuItems = 25;
            double timeselector = 0;
            bool time = false;
            while (timeselector != MonmaxMenuItems){
                Console.Clear();
                	DrawStarLine();
                    Console.ForegroundColor = ConsoleColor.Green; Console.WriteLine("\t\t\t***FRIDAY***"); Console.ResetColor();
                    Console.WriteLine("\tInput Time now in 24 hours(Input 25 to Back): ");
					DrawStarLine();                    
                	time = double.TryParse(Console.ReadLine(), out timeselector);
					Console.Clear();
				if  (timeselector >= 9 & timeselector <= 12){
					DrawStarLine();
					Console.WriteLine("Period Time: 9:00 - 12:00\nSubject: GEC 104 Math in the Modern World\nSection & Year: BSIT 1-D\nInstructor: Mr. P. Acero");
					DrawStarLine();
					Console.WriteLine("\nEnter to Back...");
                }
				else if (timeselector >= 12.5 & timeselector <= 14.5){
					DrawStarLine();
					Console.WriteLine("Period Time: 12:30 - 2:30\nSubject: PHYS 121\nSection & Year: ACT 1-C\nInstructor: Mr. E. Serrano");
					DrawStarLine();
					Console.WriteLine("\nEnter to Back...");
                }
				else if(timeselector != MonmaxMenuItems){
					Console.WriteLine("NO SCHEDULE ASSIGN/Typing error (Press any key...)");
                            }
                else{
                    Console.WriteLine("Press any key...");
                }
                Console.ReadKey();
            }                    	
                    	
            }
            private static void AWRoom103(){
            Console.Clear();
            DrawStarLine();
            Console.ForegroundColor = ConsoleColor.Green; Console.WriteLine("\t\t**********CCS VOAG ROOM 103 ALL WEEK SCHEDULE**********\n"); Console.ResetColor();
			Console.WriteLine("\tMONDAY\nPeriod Time: 8:00 - 9:30\nSubject: ENGL 121 Comm. for IT\nSection & Year: ACT 1-C\nInstructor: Mrs. Fernandez\nPeriod Time: 9:30 - 10:00\nSubject: ICT 1\nSection & Year: 1-B\nInstructor: Mr. De Jesus\nPeriod Time: 10:30 - 12:00\nSubject: SOCS 3 Politics & Gov. in Phil. Cons.\nSection & Year: BSIT 3-B/3-C\nInstructor: Mr. Lacao-cao\nPeriod Time: 1:00 - 2:30\nSubject: ITEP 208 Service Culture\nSection & Year: BSIT 3-C\nInstructor: Mr. F. Balahadia\nPeriod Time: 4:00 - 5:00\nSubject: MATH 121\nSection & Year: ACT 1-C\nInstructor: Mr. I. Castro");
			DrawStarLine();
			Console.WriteLine("\tTUESDAY\nPeriod Time: 8:00 - 9:30\nSubject: PI 100 Life & Works of Rizal\nSection & Year: ACT 1-C\nInstructor: Mr. Lacao-cao\nPeriod Time: 9:30 - 11:00\nSubject: MATH 221 Probabilities of Statistics\nSection & Year: ACT 2-A\nInstructor: E. Benedictos\nPeriod Time: 11:00 - 12:00\nSubject: CT 214 Database System\nSection & Year: ACT 2-A\nInstructor: Mr. Astoveza\nPeriod Time: 12:30 - 2:30\nSubject: PHYS 121\nSection & Year: ACT 1-C\nInstructor: Mr. E. Serrano\nPeriod Time: 2:30 - 4:00\nSubject: GEC 102 Reading in Phil. History\nSection & Year: BSIT 1-B\nInstructor: Mr. Lacao-cao");
			DrawStarLine();
			Console.WriteLine("\tWEDNESDAY\nPeriod Time: 9:30 - 11:00\nSubject: MATH 221 Probabilities of Statistics\nSection & Year: ACT 2-A\nInstructor: E. Benedictos\nPeriod Time: 12:30 - 4:00\nSubject: PHYS 121\nSection & Year: ACT 1-C\nInstructor: Mr. E. Serrano\nPeriod Time: 4:00 - 5:00\nSubject: MATH 121\nSection & Year: ACT 1-C\nInstructor: Mr. I. Castro");
			DrawStarLine();
			Console.WriteLine("\tTHURSDAY\nPeriod Time: 7:30 - 9:00\nSubject: PI 100 Life & Works of Rizal\nSection & Year: ACT 1-C\nInstructor: Mr. Lacao-cao\nPeriod Time: 9:00 - 11:00\nSubject: GEC 102 Reading in Phil. History\nSection & Year: BSIT 1-C\nInstructor:  Ms. San Roque\nPeriod Time: 11:00 - 12:00\nSubject: MATH 121\nSection & Year: ACT 1-C\nInstructor: Mr. I. Castro\nPeriod Time: 2:30 - 4:00\nSubject: FILI 121 Pagbasa at Pagsulat Tungo sa Pananaliksik\nSection & Year: ACT 1-C\nInstructor: Ms. Abulon");
			DrawStarLine();
			Console.WriteLine("\tFRIDAY\nPeriod Time: 9:00 - 12:00\nSubject: GEC 104 Math in the Modern World\nSection & Year: BSIT 1-D\nInstructor: Mr. P. Acero\nPeriod Time: 12:30 - 2:30\nSubject: PHYS 121\nSection & Year: ACT 1-C\nInstructor: Mr. E. Serrano");
            DrawStarLine();
            Console.WriteLine("\nPress any key..");
            }
        //ROOM 106 INFO.
        private static void DisplayRoom106(){
            const int maxMenuItems = 7;
            int selector = 0;
            bool good = false;
            while (selector != maxMenuItems){
                Console.Clear();
                DrawStarLine();
                    Console.ForegroundColor = ConsoleColor.Green; Console.WriteLine("\t\t***CCS VOAG ROOM 106 SCHEDULE***"); Console.ResetColor();
                DrawStarLine();
                DrawMenu106(maxMenuItems);
                //user input
                good = int.TryParse(Console.ReadLine(), out selector);
                if (good){
					switch (selector){
                        case 1:
							MonRoom106();
							break;
                        case 2:
                            TueRoom106();
                            break;
                        case 3:
                            WedRoom106();
                            break;
                        case 4:
                            ThuRoom106();
                            break;
                        case 5:
                            FriRoom106();
                            break;
                        case 6:
                            AWRoom106();
                            break;                            
                        default:
                            if (selector != maxMenuItems)
                            { ErrorMessage();
                         } break;
                    }
                }
                else
                { ErrorMessage();
                } Console.ReadKey();
            }
            }
            private static void DrawMenu106(int maxitems){ 
            Console.WriteLine("[1] = Monday\n[2] = Tuesday\n[3] = Wednesday\n[4] = Thursday\n[5] = Friday\n[6] = All Week Schedule");
            DrawStarLine();
            Console.ForegroundColor = ConsoleColor.DarkGray; Console.WriteLine("  Make your choice: type 1, 2,... or {0} Go Back to Room Choices", maxitems); Console.ResetColor();
            DrawStarLine();
            }
            private static void MonRoom106(){
            const double MonmaxMenuItems = 25;
            double timeselector = 0;
            bool time = false;
            while (timeselector != MonmaxMenuItems){
                Console.Clear();
                	DrawStarLine();
                    Console.ForegroundColor = ConsoleColor.Green; Console.WriteLine("\t\t\t***MONDAY***"); Console.ResetColor();
                    Console.WriteLine("\tInput Time now in 24 hours(Input 25 to Back): ");
					DrawStarLine();                    
                	time = double.TryParse(Console.ReadLine(), out timeselector);
					Console.Clear();
				if  (timeselector >= 7.5 & timeselector <= 9){
					DrawStarLine();
					Console.WriteLine("Period Time: 7:30 - 9:00\nSubject: ITEP 208 Service Culture\nSection & Year: BSIT 3-C\nInstructor: Mr. Balahadia");
					DrawStarLine();
					Console.WriteLine("\nEnter to Back...");
                }
				else if (timeselector > 9 & timeselector <= 10.5){
					DrawStarLine();
					Console.WriteLine("Period Time: 9:00 - 10:30\nSubject: SOCS 3\nSection & Year: BSIT 3-A\nInstructor: Ms. San Roque");
					DrawStarLine();
					Console.WriteLine("\nEnter to Back...");
                }
				else if (timeselector >= 11.5 & timeselector <= 12){
					DrawStarLine();
					Console.WriteLine("Period Time: 11:30 - 12:00\nSubject: SOCS 1 General Psychology\nSection & Year: BSIT 2-A/2-B\nInstructor: Mr. Ferrer");
					DrawStarLine();
					Console.WriteLine("\nEnter to Back...");
                }
				else if (timeselector >= 13 & timeselector <= 15){
					DrawStarLine();
				Console.WriteLine("Period Time: 1:00 - 3:00\nSubject: ITEC 205 Discrete Structure\nSection & Year: BSIT 2-B\nInstructor: Mr. A. De Luna");
					DrawStarLine();
					Console.WriteLine("\nEnter to Back...");
					}
				else if (timeselector > 15 & timeselector <= 16){
					DrawStarLine();
				Console.WriteLine("Period Time: 3:00 - 4:00\nSubject: BBC 104\nSection & Year: BSBA 2\nInstructor: Mr. Santelices");
					DrawStarLine();
					Console.WriteLine("\nEnter to Back...");
					}
				else if (timeselector > 16 & timeselector <= 17){
					DrawStarLine();
				Console.WriteLine("Period Time: 4:00 - 5:00\nSubject: GEC 101 Reading in Phil. History\nSection & Year: BSIT 1-B\nInstructor: Ms. Leopando");
					DrawStarLine();
					Console.WriteLine("\nEnter to Back...");
					}
				else if(timeselector != MonmaxMenuItems){
					Console.WriteLine("NO SCHEDULE ASSIGN/Typing error (Press any key...)");
                            }
                else{
                    Console.WriteLine("Press any key...");
                }
                Console.ReadKey();
            }                    	       	
            }
            private static void TueRoom106(){
            const double MonmaxMenuItems = 25;
            double timeselector = 0;
            bool time = false;
            while (timeselector != MonmaxMenuItems){
                Console.Clear();
                DrawStarLine();
                    	Console.ForegroundColor = ConsoleColor.Green; Console.WriteLine("\t\t\t***TUESDAY***"); Console.ResetColor();
                    	Console.WriteLine("\tInput Time now in 24 hours(Input 25 to Back): ");  DrawStarLine();
                time = double.TryParse(Console.ReadLine(), out timeselector);
                Console.Clear();
				if (timeselector >= 7 && timeselector <= 8){DrawStarLine();
					Console.WriteLine("Period Time: 7:00 - 8:00\nSubject: STENO\nSection & Year: BSOA 1-C\nInstructor: Mrs. Casifio");
					DrawStarLine();
					Console.WriteLine("\nEnter to Back...");
                }
				else if (timeselector > 8 && timeselector <= 9.5){DrawStarLine();
					Console.WriteLine("Period Time: 8:00 - 9:30\nSubject: SOCS 211 Society & Culture w/ Family Planning\nSection & Year: ACT 2-A\nInstructor: J. Carangulan");
					DrawStarLine();
					Console.WriteLine("\nEnter to Back...");
                }
				else if (timeselector >= 10.5 && timeselector <= 12){DrawStarLine();
					Console.WriteLine("Period Time: 10:30 - 12:00\nSubject: ENGL 311 Technical Writing\nSection & Year: BSIT 3-A\nInstructor: M. Fernandez");
					DrawStarLine();
					Console.WriteLine("\nEnter to Back...");
                }
				else if (timeselector > 12 & timeselector <= 13.5){
					DrawStarLine();
				Console.WriteLine("Period Time: 12:00 - 1:30\nSubject: ENGL 311 Technical Writing\nSection & Year: BSIT 3-B\nInstructor: M. Fernandez");
					DrawStarLine();
					Console.WriteLine("\nEnter to Back...");
					}
				else if (timeselector > 13.5 & timeselector <= 16){
					DrawStarLine();
				Console.WriteLine("Period Time: 1:30 - 4:00\nSubject: STENO\nSection & Year: BSOA 1-C\nInstructor: Mrs. Casifio");
					DrawStarLine();
					Console.WriteLine("\nEnter to Back...");
					}
				else if (timeselector >  16& timeselector <= 17){
					DrawStarLine();
				Console.WriteLine("Period Time: 4:00 - 5:00\nSubject: GEC 101 Reading in Phil. History\nSection & Year: BSIT 1-B\nInstructor: Ms. Leopando");
					DrawStarLine();
					Console.WriteLine("\nEnter to Back...");
					}
				else if (timeselector != MonmaxMenuItems){
					Console.WriteLine("NO SCHEDULE ASSIGN/Typing error (Press any key...)");
                            }
                else{
                    Console.WriteLine("Press any key...");
                }
                Console.ReadKey();
            }                    	        	
            }
            private static void WedRoom106(){
            const double MonmaxMenuItems = 25;
            double timeselector = 0;
            bool time = false;
            while (timeselector != MonmaxMenuItems){
                Console.Clear();
                	DrawStarLine();
                    Console.ForegroundColor = ConsoleColor.Green; Console.WriteLine("\t\t\t***WEDNESDAY***"); Console.ResetColor();
                    Console.WriteLine("\tInput Time now in 24 hours(Input 25 to Back): ");
					DrawStarLine();                    
                	time = double.TryParse(Console.ReadLine(), out timeselector);
					Console.Clear();
				if  (timeselector >= 7.5 & timeselector <= 9){
					DrawStarLine();
					Console.WriteLine("Period Time: 7:30 - 9:00\nSubject: GEC 101 UTS\nSection & Year: BSIT 1-D\nInstructor: Mr. Lacao-cao");
					DrawStarLine();
					Console.WriteLine("\nEnter to Back...");
                }
				else if (timeselector > 9 & timeselector <= 10.5){
					DrawStarLine();
					Console.WriteLine("Period Time: 9:00 - 10:30\nSubject: SOCS 3\nSection & Year: BSIT 3-A\nInstructor: Ms. San Roque");
					DrawStarLine();
					Console.WriteLine("\nEnter to Back...");
                }
				else if (timeselector >= 11.5 & timeselector <= 12){
					DrawStarLine();
					Console.WriteLine("Period Time: 11:30 - 12:00\nSubject: SOCS 1 General Psychology\nSection & Year: BSIT 2-A/2-B\nInstructor: Mr. Ferrer");
					DrawStarLine();
					Console.WriteLine("\nEnter to Back...");
                }
				else if (timeselector >= 13 & timeselector <= 14.5){
					DrawStarLine();
					Console.WriteLine("Period Time: 1:00 - 2:30\nSubject: MATH 211 Probability & Statistics\nSection & Year: BSIT 2-A/2-B\nInstructor: Mr. E. Benedictor");
					DrawStarLine();
					Console.WriteLine("\nEnter to Back...");
                }
				else if (timeselector >= 15 & timeselector <= 16){
					DrawStarLine();
				Console.WriteLine("Period Time: 3:00 - 4:00\nSubject: ITEC 205 Discrete Structure\nSection & Year: BSIT 2-B\nInstructor: Mr. A. De Luna");
					DrawStarLine();
					Console.WriteLine("\nEnter to Back...");
					}
				else if (timeselector > 16 & timeselector <= 17){
					DrawStarLine();
				Console.WriteLine("Period Time: 4:00 - 5:00\nSubject: GEC 101 Reading in Phil. History\nSection & Year: BSIT 1-B\nInstructor: Ms. Leopando");
					DrawStarLine();
					Console.WriteLine("\nEnter to Back...");
					}

				else if(timeselector != MonmaxMenuItems){
					Console.WriteLine("NO SCHEDULE ASSIGN/Typing error (Press any key...)");
                            }
                else{
                    Console.WriteLine("Press any key...");
                }
                Console.ReadKey();
            }                    	         	
            }
            private static void ThuRoom106(){
            const double MonmaxMenuItems = 25;
            double timeselector = 0;
            bool time = false;
            while (timeselector != MonmaxMenuItems){
                Console.Clear();
                	DrawStarLine();
                    Console.ForegroundColor = ConsoleColor.Green; Console.WriteLine("\t\t\t***THURSDAY***"); Console.ResetColor();
                    Console.WriteLine("\tInput Time now in 24 hours(Input 25 to Back): ");
					DrawStarLine();                    
                	time = double.TryParse(Console.ReadLine(), out timeselector);
					Console.Clear();
				if  (timeselector >= 7 & timeselector <= 10.5){
					DrawStarLine();
					Console.WriteLine("Period Time: 7:00 - 10:30\nSubject: STENO\nSection & Year: BSOA 1-C\nInstructor: Mrs. Casifio");
					DrawStarLine();
					Console.WriteLine("\nEnter to Back...");
                }
				else if (timeselector > 10.5 & timeselector <= 12){
					DrawStarLine();
					Console.WriteLine("eroid Time: 10:30 - 12:00\nSubject: ENGL 311 Technical Writing\nSection & Year: BSIT 3-A\nInstructor: M. Fernandez");
					DrawStarLine();
					Console.WriteLine("\nEnter to Back...");
                }
				else if (timeselector > 12 & timeselector <= 13.5){
					DrawStarLine();
					Console.WriteLine("Period Time: 12:00 - 1:30\nSubject: ENGL 311 Technical Writing\nSection & Year: BSIT 3-B\nInstructor: M. Fernandez");
					DrawStarLine();
					Console.WriteLine("\nEnter to Back...");
                }
				else if (timeselector > 13.5 & timeselector <= 16){
					DrawStarLine();
					Console.WriteLine("Period Time: 1:30 - 4:00\nSubject: STENO\nSection & Year: BSOA 1-C\nInstructor: Mrs. Casifio");
					DrawStarLine();
					Console.WriteLine("\nEnter to Back...");
                }
				else if(timeselector != MonmaxMenuItems){
					Console.WriteLine("NO SCHEDULE ASSIGN/Typing error (Press any key...)");
                            }
                else{
                    Console.WriteLine("Press any key...");
                }
                Console.ReadKey();
            }                    	      	
            }
            private static void FriRoom106()
            {
            const double MonmaxMenuItems = 25;
            double timeselector = 0;
            bool time = false;
            while (timeselector != MonmaxMenuItems){
                Console.Clear();
                	DrawStarLine();
                    Console.ForegroundColor = ConsoleColor.Green; Console.WriteLine("\t\t\t***FRIDAY***"); Console.ResetColor();
                    Console.WriteLine("\tInput Time now in 24 hours(Input 25 to Back): ");
					DrawStarLine();                    
                	time = double.TryParse(Console.ReadLine(), out timeselector);
					Console.Clear();
				if  (timeselector >= 7 & timeselector <= 10){
					DrawStarLine();
					Console.WriteLine("Period Time: 7:00 - 10:00\nSubject: ELEF 201\nSection & Year: BSIT 2-A/BSIT 2-B/BSIT 3-C\nInstructor: Ms. Corpuz");
					DrawStarLine();
					Console.WriteLine("\nEnter to Back...");
                }
				else if (timeselector >= 13 & timeselector <= 14.5){
					DrawStarLine();
					Console.WriteLine("Period Time: 1:00 - 2:30\nSubject: MATH 211 Probability & Statistics\nSection & Year: BSIT 2-A/2-B\nInstructor: Mr. E. Benedictor");
					DrawStarLine();
					Console.WriteLine("\nEnter to Back...");
                }
				else if (timeselector > 14.5 & timeselector <= 16){
					DrawStarLine();
				Console.WriteLine("Period Time: 2:30 - 4:00\nSubject: GEC 101 Reading in Phil. History\nSection & Year: BSIT 1-B\nInstructor: Ms. Leopando");
					DrawStarLine();
					Console.WriteLine("\nEnter to Back...");
					}
				else if(timeselector != MonmaxMenuItems){
					Console.WriteLine("NO SCHEDULE ASSIGN/Typing error (Press any key...)");
                            }
                else{
                    Console.WriteLine("Press any key...");
                }
                Console.ReadKey();
            }                    	
                    	
            }
            private static void AWRoom106(){
            Console.Clear();
            DrawStarLine();
            Console.ForegroundColor = ConsoleColor.Green; Console.WriteLine("\t\t**********CCS VOAG ROOM 106 ALL WEEK SCHEDULE**********\n"); Console.ResetColor();
			Console.WriteLine("\tMONDAY\nPeriod Time: 7:30 - 9:00\nSubject: ITEP 208 Service Culture\nSection & Year: BSIT 3-C\nInstructor: Mr. Balahadia\nPeriod Time: 9:00 - 10:30\nSubject: SOCS 3\nSection & Year: BSIT 3-A\nInstructor: Ms. San Roque\nPeriod Time: 11:30 - 12:00\nSubject: SOCS 1 General Psychology\nSection & Year: BSIT 2-A/2-B\nInstructor: Mr. Ferrer\nPeriod Time: 1:00 - 3:00\nSubject: ITEC 205 Discrete Structure\nSection & Year: BSIT 2-B\nInstructor: Mr. A. De Luna\nPeriod Time: 3:00 - 4:00\nSubject: BBC 104\nSection & Year: BSBA 2\nInstructor: Mr. Santelices\nPeriod Time: 4:00 - 5:00\nSubject: GEC 101 Reading in Phil. History\nSection & Year: BSIT 1-B\nInstructor: Ms. Leopando");
			DrawStarLine();
			Console.WriteLine("\tTUESDAY\nPeriod Time: 7:00 - 8:00\nSubject: STENO\nSection & Year: BSOA 1-C\nInstructor: Mrs. Casifio\nPeriod Time: 8:00 - 9:30\nSubject: SOCS 211 Society & Culture w/ Family Planning\nSection & Year: ACT 2-A\nInstructor: J. Carangulan\nPeriod Time: 10:30 - 12:00\nSubject: ENGL 311 Technical Writing\nSection & Year: BSIT 3-A\nInstructor: M. Fernandez\nPeriod Time: 12:00 - 1:30\nSubject: ENGL 311 Technical Writing\nSection & Year: BSIT 3-B\nInstructor: M. Fernandez\nPeriod Time: 1:30 - 4:00\nSubject: STENO\nSection & Year: BSOA 1-C\nInstructor: Mrs. Casifio\nPeriod Time: 4:00 - 5:00\nSubject: GEC 101 Reading in Phil. History\nSection & Year: BSIT 1-B\nInstructor: Ms. Leopando");
			DrawStarLine();
			Console.WriteLine("\tWEDNESDAY\nPeriod Time: 7:30 - 9:00\nSubject: GEC 101 UTS\nSection & Year: BSIT 1-D\nInstructor: Mr. Lacao-cao\nPeriod Time: 9:00 - 10:30\nSubject: SOCS 3\nSection & Year: BSIT 3-A\nInstructor: Ms. San Roque\nPeriod Time: 11:30 - 12:00\nSubject: SOCS 1 General Psychology\nSection & Year: BSIT 2-A/2-B\nInstructor: Mr. Ferrer\nPeriod Time: 1:00 - 2:30\nSubject: MATH 211 Probability & Statistics\nSection & Year: BSIT 2-A/2-B\nInstructor: Mr. E. Benedictor\nPeriod Time: 3:00 - 4:00\nSubject: ITEC 205 Discrete Structure\nSection & Year: BSIT 2-B\nInstructor: Mr. A. De Luna\nPeriod Time: 4:00 - 5:00\nSubject: GEC 101 Reading in Phil. History\nSection & Year: BSIT 1-B\nInstructor: Ms. Leopando");
			DrawStarLine();
			Console.WriteLine("\tTHURSDAY\nPeriod Time: 7:00 - 10:30\nSubject: STENO\nSection & Year: BSOA 1-C\nInstructor: Mrs. Casifio\nPeriod Time: 10:30 - 12:00\nSubject: ENGL 311 Technical Writing\nSection & Year: BSIT 3-A\nInstructor: M. Fernandez\nPeriod Time: 12:00 - 1:30\nSubject: ENGL 311 Technical Writing\nSection & Year: BSIT 3-B\nInstructor: M. Fernandez\nPeriod Time: 1:30 - 4:00\nSubject: STENO\nSection & Year: BSOA 1-C\nInstructor: Mrs. Casifio");
			DrawStarLine();
			Console.WriteLine("\tFRIDAY\nPeriod Time: 7:00 - 10:00\nSubject: ELEF 201\nSection & Year: BSIT 2-A/BSIT 2-B/BSIT 3-C\nInstructor: Ms. Corpuz\nPeriod Time: 1:00 - 2:30\nSubject: MATH 211 Probability & Statistics\nSection & Year: BSIT 2-A/2-B\nInstructor: Mr. E. Benedictor\nPeriod Time: 2:30 - 4:00\nSubject: GEC 101 Reading in Phil. History\nSection & Year: BSIT 1-B\nInstructor: Ms. Leopando");
            DrawStarLine();
            Console.WriteLine("\nPress any key..");
            }
        //ROOM 107 INFO.
        private static void DisplayRoom107(){
            const int maxMenuItems = 7;
            int selector = 0;
            bool good = false;
            while (selector != maxMenuItems){
                Console.Clear();
                DrawStarLine();
                    Console.ForegroundColor = ConsoleColor.Green; Console.WriteLine("\t\t***CCS VOAG ROOM 107 SCHEDULE***"); Console.ResetColor();
                DrawStarLine();
                DrawMenu107(maxMenuItems);
                //user input
                good = int.TryParse(Console.ReadLine(), out selector);
                if (good){
					switch (selector){
                        case 1:
							MonRoom107();
							break;
                        case 2:
                            TueRoom107();
                            break;
                        case 3:
                            WedRoom107();
                            break;
                        case 4:
                            ThuRoom107();
                            break;
                        case 5:
                            FriRoom107();
                            break;
                        case 6:
                            AWRoom107();
                            break;                            
                        default:
                            if (selector != maxMenuItems)
                            { ErrorMessage();
                         } break;
                    }
                }
                else
                { ErrorMessage();
                } Console.ReadKey();
            }
            }
            private static void DrawMenu107(int maxitems){ 
            Console.WriteLine("[1] = Monday\n[2] = Tuesday\n[3] = Wednesday\n[4] = Thursday\n[5] = Friday\n[6] = All Week Schedule");
            DrawStarLine();
            Console.ForegroundColor = ConsoleColor.DarkGray; Console.WriteLine("  Make your choice: type 1, 2,... or {0} Go Back to Room Choices", maxitems); Console.ResetColor();
            DrawStarLine();
            }
            private static void MonRoom107(){
            const double MonmaxMenuItems = 25;
            double timeselector = 0;
            bool time = false;
            while (timeselector != MonmaxMenuItems){
                Console.Clear();
                	DrawStarLine();
                    Console.ForegroundColor = ConsoleColor.Green; Console.WriteLine("\t\t\t***MONDAY***"); Console.ResetColor();
                    Console.WriteLine("\tInput Time now in 24 hours(Input 25 to Back): ");
					DrawStarLine();                    
                	time = double.TryParse(Console.ReadLine(), out timeselector);
					Console.Clear();
				if  (timeselector >= 7 & timeselector <= 9){
					DrawStarLine();
					Console.WriteLine("Period Time: 7:00 - 9:00\nSubject: ITEP 310 System Analysis & Design\nSection & Year: BSIT 3-A\nInstructor: Mr. De Luna");
					DrawStarLine();
					Console.WriteLine("\nEnter to Back...");
                }
				else if (timeselector >= 10 & timeselector <= 12.5){
					DrawStarLine();
					Console.WriteLine("Period Time: 10:00 - 12:30\nSubject: COMTECH Introduction to Computer Science\nSection & Year: BSAB 1\nInstructor: Mr. Gustilo ll");
					DrawStarLine();
					Console.WriteLine("\nEnter to Back...");
                }
				else if (timeselector > 12.5 & timeselector <= 17){
					DrawStarLine();
					Console.WriteLine("Period Time: 12:30 - 5:00\nSubject: Integrated Software Application (Word Processing, Presentation & Publiser)\nSection & Year: ICT 1 1-B\nInstructor: Mr. De Jesus");
					DrawStarLine();
					Console.WriteLine("\nEnter to Back...");
                }
				else if(timeselector != MonmaxMenuItems){
					Console.WriteLine("NO SCHEDULE ASSIGN/Typing error (Press any key...)");
                            }
                else{
                    Console.WriteLine("Press any key...");
                }
                Console.ReadKey();
            }                    	       	
            }
            private static void TueRoom107(){
            const double MonmaxMenuItems = 25;
            double timeselector = 0;
            bool time = false;
            while (timeselector != MonmaxMenuItems){
                Console.Clear();
                DrawStarLine();
                    	Console.ForegroundColor = ConsoleColor.Green; Console.WriteLine("\t\t\t***TUESDAY***"); Console.ResetColor();
                    	Console.WriteLine("\tInput Time now in 24 hours(Input 25 to Back): ");  DrawStarLine();
                time = double.TryParse(Console.ReadLine(), out timeselector);
                Console.Clear();
				if (timeselector >= 7 && timeselector <= 9.5){DrawStarLine();
					Console.WriteLine("Period Time: 7:00 - 9:30\nSubject: BBC 109 E-Comm & Internet Marketing\nSection & Year: BSBA 4-MMB\nInstructor: Mr. Santelices");
					DrawStarLine();
					Console.WriteLine("\nEnter to Back...");
                }
				else if (timeselector > 9.5 && timeselector <= 12){DrawStarLine();
					Console.WriteLine("Period Time: 9:30 - 12:00\nSubject: BBC 109 E-Comm & Internet Marketing\nSection & Year: BSBA 4-MMA\nInstructor: Mr. Santelices");
					DrawStarLine();
					Console.WriteLine("\nEnter to Back...");
                }
				else if (timeselector > 12 && timeselector <= 17){DrawStarLine();
					Console.WriteLine("Period Time: 12:00 - 5:00\nSubject: BBC 109 E-Commerce\nSection & Year: FM-A\nInstructor: Mr. J. Diaz");
					DrawStarLine();
					Console.WriteLine("\nEnter to Back...");
                }
				else if (timeselector != MonmaxMenuItems){
					Console.WriteLine("NO SCHEDULE ASSIGN/Typing error (Press any key...)");
                            }
                else{
                    Console.WriteLine("Press any key...");
                }
                Console.ReadKey();
            }                    	        	
            }
            private static void WedRoom107(){
            const double MonmaxMenuItems = 25;
            double timeselector = 0;
            bool time = false;
            while (timeselector != MonmaxMenuItems){
                Console.Clear();
                	DrawStarLine();
                    Console.ForegroundColor = ConsoleColor.Green; Console.WriteLine("\t\t\t***WEDNESDAY***"); Console.ResetColor();
                    Console.WriteLine("\tInput Time now in 24 hours(Input 25 to Back): ");
					DrawStarLine();                    
                	time = double.TryParse(Console.ReadLine(), out timeselector);
					Console.Clear();
				if  (timeselector >= 7 & timeselector <= 12){
					DrawStarLine();
					Console.WriteLine("Period Time: 7:00 - 12:00\nSubject: KEYBOARDING Keyboarding & Documents Processing\nSection & Year: 1-A\nInstructor: Mrs. C. Diaz");
					DrawStarLine();
					Console.WriteLine("\nEnter to Back...");
                }
				else if (timeselector > 12 & timeselector <= 14){
					DrawStarLine();
					Console.WriteLine("Period Time: 12:00 - 2:00\nSubject: IS ELECT 4 IS Elective 3\nSection & Year: BSIS 4-A\nInstructor: Mr. F. Urera");
					DrawStarLine();
					Console.WriteLine("\nEnter to Back...");
                }
				else if(timeselector != MonmaxMenuItems){
					Console.WriteLine("NO SCHEDULE ASSIGN/Typing error (Press any key...)");
                            }
                else{
                    Console.WriteLine("Press any key...");
                }
                Console.ReadKey();
            }                    	         	
            }
            private static void ThuRoom107(){
            const double MonmaxMenuItems = 25;
            double timeselector = 0;
            bool time = false;
            while (timeselector != MonmaxMenuItems){
                Console.Clear();
                	DrawStarLine();
                    Console.ForegroundColor = ConsoleColor.Green; Console.WriteLine("\t\t\t***THURSDAY***"); Console.ResetColor();
                    Console.WriteLine("\tInput Time now in 24 hours(Input 25 to Back): ");
					DrawStarLine();                    
                	time = double.TryParse(Console.ReadLine(), out timeselector);
					Console.Clear();
				if  (timeselector >= 7 & timeselector <= 9.5){
					DrawStarLine();
					Console.WriteLine("Period Time: 7:00 - 9:30\nSubject: BBC 109 E-Comm & Internet Marketing\nSection & Year: BSBA 4-MMB\nInstructor: Mr. Santelices");
					DrawStarLine();
					Console.WriteLine("\nEnter to Back...");
                }
				else if (timeselector > 9.5 & timeselector <= 12){
					DrawStarLine();
					Console.WriteLine("Period Time: 9:30 - 12:00\nSubject: BBC 109 E-Comm & Internet Marketing\nSection & Year: BSBA 4-MMA\nInstructor: Mr. Santelices");
					DrawStarLine();
					Console.WriteLine("\nEnter to Back...");
                }
				else if (timeselector > 12 & timeselector <= 16){
					DrawStarLine();
					Console.WriteLine("Period Time: 12:00 - 5:00\nSubject: KEYBOARDING\nSection & Year: BSOA 1-C\nInstructor: Mrs. C. Diaz");
					DrawStarLine();
					Console.WriteLine("\nEnter to Back...");
                }
				else if(timeselector != MonmaxMenuItems){
					Console.WriteLine("NO SCHEDULE ASSIGN/Typing error (Press any key...)");
                            }
                else{
                    Console.WriteLine("Press any key...");
                }
                Console.ReadKey();
            }                    	      	
            }
            private static void FriRoom107()
            {
            const double MonmaxMenuItems = 25;
            double timeselector = 0;
            bool time = false;
            while (timeselector != MonmaxMenuItems){
                Console.Clear();
                	DrawStarLine();
                    Console.ForegroundColor = ConsoleColor.Green; Console.WriteLine("\t\t\t***FRIDAY***"); Console.ResetColor();
                    Console.WriteLine("\tInput Time now in 24 hours(Input 25 to Back): ");
					DrawStarLine();                    
                	time = double.TryParse(Console.ReadLine(), out timeselector);
					Console.Clear();
				if  (timeselector >= 7 & timeselector <= 12){
					DrawStarLine();
					Console.WriteLine("Period Time: 7:00 - 12:00\nSubject: Integrated Software Application (Word Processing, Presentation & Publiser)\nSection & Year: ICT 1 1-A\nInstructor: Mr. De Jesus");
					DrawStarLine();
					Console.WriteLine("\nEnter to Back...");
                }
				else if (timeselector > 12 & timeselector <= 17){
					DrawStarLine();
					Console.WriteLine("Period Time: 12:00 - 5:00\nSubject: BBC 104 Fundamental of Programming & Database Theory Application\nSection & Year: BSBA 2\nInstructor: ");
					DrawStarLine();
					Console.WriteLine("\nEnter to Back...");
                }
				else if(timeselector != MonmaxMenuItems){
					Console.WriteLine("NO SCHEDULE ASSIGN/Typing error (Press any key...)");
                            }
                else{
                    Console.WriteLine("Press any key...");
                }
                Console.ReadKey();
            }                    	
                    	
            }
            private static void AWRoom107(){
            Console.Clear();
            DrawStarLine();
            Console.ForegroundColor = ConsoleColor.Green; Console.WriteLine("\t\t**********CCS VOAG ROOM 107 ALL WEEK SCHEDULE**********\n"); Console.ResetColor();
			Console.WriteLine("\tMONDAY\nPeriod Time: 7:00 - 9:00\nSubject: ITEP 310 System Analysis & Design\nSection & Year: BSIT 3-A\nInstructor: Mr. De Luna\nPeriod Time: 10:00 - 12:30\nSubject: COMTECH Introduction to Computer Science\nSection & Year: BSAB 1\nInstructor: Mr. Gustilo ll\nPeriod Time: 12:30 - 5:00\nSubject: Integrated Software Application (Word Processing, Presentation & Publiser)\nSection & Year: ICT 1 1-B\nInstructor: Mr. De Jesus");
			DrawStarLine();
			Console.WriteLine("\tTUESDAY\nPeriod Time: 7:00 - 9:30\nSubject: BBC 109 E-Comm & Internet Marketing\nSection & Year: BSBA 4-MMB\nInstructor: Mr. Santelices\nPeriod Time: 9:30 - 12:00\nSubject: BBC 109 E-Comm & Internet Marketing\nSection & Year: BSBA 4-MMA\nInstructor: Mr. Santelices\nPeriod Time: 12:00 - 5:00\nSubject: BBC 109 E-Commerce\nSection & Year: FM-A\nInstructor: Mr. J. Diaz");
			DrawStarLine();
			Console.WriteLine("\tWEDNESDAY\nPeriod Time: 7:00 - 12:00\nSubject: KEYBOARDING Keyboarding & Documents Processing\nSection & Year: 1-A\nInstructor: Mrs. C. Diaz\nPeriod Time: 12:00 - 2:00\nSubject: IS ELECT 4 IS Elective 3\nSection & Year: BSIS 4-A\nInstructor: Mr. F. Urera");
			DrawStarLine();
			Console.WriteLine("\tTHURSDAY\nPeriod Time: 7:00 - 9:30\nSubject: BBC 109 E-Comm & Internet Marketing\nSection & Year: BSBA 4-MMB\nInstructor: Mr. Santelices\nPeriod Time: 9:30 - 12:00\nSubject: BBC 109 E-Comm & Internet Marketing\nSection & Year: BSBA 4-MMA\nInstructor: Mr. Santelices\nPeriod Time: 12:00 - 5:00\nSubject: KEYBOARDING\nSection & Year: BSOA 1-C\nInstructor: Mrs. C. Diaz");
			DrawStarLine();
			Console.WriteLine("\tFRIDAY\nPeriod Time: 7:00 - 12:00\nSubject: Integrated Software Application (Word Processing, Presentation & Publiser)\nSection & Year: ICT 1 1-A\nInstructor: Mr. De Jesus\nPeriod Time: 12:00 - 5:00\nSubject: BBC 104 Fundamental of Programming & Database Theory Application\nSection & Year: BSBA 2\nInstructor: ");
            DrawStarLine();
            Console.WriteLine("\nPress any key..");
            }
        //ROOM 108 INFO.
        private static void DisplayRoom108(){
            const int maxMenuItems = 7;
            int selector = 0;
            bool good = false;
            while (selector != maxMenuItems){
                Console.Clear();
                DrawStarLine();
                    Console.ForegroundColor = ConsoleColor.Green; Console.WriteLine("\t\t***CCS VOAG ROOM 108 SCHEDULE***"); Console.ResetColor();
                DrawStarLine();
                DrawMenu108(maxMenuItems);
                //user input
                good = int.TryParse(Console.ReadLine(), out selector);
                if (good){
					switch (selector){
                        case 1:
							MonRoom108();
							break;
                        case 2:
                            TueRoom108();
                            break;
                        case 3:
                            WedRoom108();
                            break;
                        case 4:
                            ThuRoom108();
                            break;
                        case 5:
                            FriRoom108();
                            break;
                        case 6:
                            AWRoom108();
                            break;                            
                        default:
                            if (selector != maxMenuItems)
                            { ErrorMessage();
                         } break;
                    }
                }
                else
                { ErrorMessage();
                } Console.ReadKey();
            }
            }
            private static void DrawMenu108(int maxitems){ 
            Console.WriteLine("[1] = Monday\n[2] = Tuesday\n[3] = Wednesday\n[4] = Thursday\n[5] = Friday\n[6] = All Week Schedule");
            DrawStarLine();
            Console.ForegroundColor = ConsoleColor.DarkGray; Console.WriteLine("  Make your choice: type 1, 2,... or {0} Go Back to Room Choices", maxitems); Console.ResetColor();
            DrawStarLine();
            }
            private static void MonRoom108(){
            const double MonmaxMenuItems = 25;
            double timeselector = 0;
            bool time = false;
            while (timeselector != MonmaxMenuItems){
                Console.Clear();
                	DrawStarLine();
                    Console.ForegroundColor = ConsoleColor.Green; Console.WriteLine("\t\t\t***MONDAY***"); Console.ResetColor();
                    Console.WriteLine("\tInput Time now in 24 hours(Input 25 to Back): ");
					DrawStarLine();                    
                	time = double.TryParse(Console.ReadLine(), out timeselector);
					Console.Clear();
				if  (timeselector >= 7.5 & timeselector <= 10.5){
					DrawStarLine();
					Console.WriteLine("Period Time: 7:30 - 10:30\nSubject: ICT\nSection & Year: BSP 1-B\nInstructor: Ms. Zerah Mortel");
					DrawStarLine();
					Console.WriteLine("\nEnter to Back...");
                }
				else if (timeselector > 10.5 & timeselector <= 12){
					DrawStarLine();
					Console.WriteLine("Period Time: 10:30 - 12:00\nSubject: ITEC 101 Intro. to Computing\nSection & Year: BSCS 1-A\nInstructor: Ms. Zerah Mortel");
					DrawStarLine();
					Console.WriteLine("\nEnter to Back...");
                }
				else if (timeselector >= 12.5 & timeselector <= 15.5){
					DrawStarLine();
					Console.WriteLine("Period Time: 12:30 - 3:30\nSubject: ICT\nSection & Year: BSOA 1-C\nInstructor: Mr. R. Diaz");
					DrawStarLine();
					Console.WriteLine("\nEnter to Back...");
                }
				else if (timeselector > 15.5 & timeselector <= 17){
					DrawStarLine();
				Console.WriteLine("Period Time: 3:30 - 5:00\nSubject: ITEP 310\nSection & Year: BSIT 3-B\nInstructor: Mr. De Lucio");
					DrawStarLine();
					Console.WriteLine("\nEnter to Back...");
					}
				else if(timeselector != MonmaxMenuItems){
					Console.WriteLine("NO SCHEDULE ASSIGN/Typing error (Press any key...)");
                            }
                else{
                    Console.WriteLine("Press any key...");
                }
                Console.ReadKey();
            }                    	       	
            }
            private static void TueRoom108(){
            const double MonmaxMenuItems = 25;
            double timeselector = 0;
            bool time = false;
            while (timeselector != MonmaxMenuItems){
                Console.Clear();
                DrawStarLine();
                    	Console.ForegroundColor = ConsoleColor.Green; Console.WriteLine("\t\t\t***TUESDAY***"); Console.ResetColor();
                    	Console.WriteLine("\tInput Time now in 24 hours(Input 25 to Back): ");  DrawStarLine();
                time = double.TryParse(Console.ReadLine(), out timeselector);
                Console.Clear();
				if (timeselector >= 7 && timeselector <= 9){DrawStarLine();
					Console.WriteLine("Period Time: 7:00 - 9:00\nSubject: SHS MIL 12\nSection & Year: Grade 12 (HUMS)\nInstructor: Mr. R. Diaz");
					DrawStarLine();
					Console.WriteLine("\nEnter to Back...");
                }
				else if (timeselector > 10 && timeselector <= 12.5){DrawStarLine();
					Console.WriteLine("Period Time: 10:00 - 12:30\nSubject: COMTECH Introduction to Computer Science\nSection & Year: BSAB 1\nInstructor: Mr. Gustilo ll");
					DrawStarLine();
					Console.WriteLine("\nEnter to Back...");
                }
				else if (timeselector >= 13 && timeselector <= 14){DrawStarLine();
					Console.WriteLine("Period Time: 1:00 - 2:00\nSubject: ITEC 101\nSection & Year: BSIT 1-B\nInstructor: Ms. Mortel");
					DrawStarLine();
					Console.WriteLine("\nEnter to Back...");
                }
				else if (timeselector > 14 & timeselector <= 15){DrawStarLine();
					DrawStarLine();
				Console.WriteLine("Period Time: 2:00 - 3:00\nSubject: ITEC 101\nSection & Year: BSIT 1-C\nInstructor: Ms. Mortel");
					DrawStarLine();
					Console.WriteLine("\nEnter to Back...");
					}
				else if (timeselector > 15 & timeselector <= 16){DrawStarLine();
					DrawStarLine();
				Console.WriteLine("Period Time: 3:00 - 4:00\nSubject: ITEC 101\nSection & Year: BSIT 1-E\nInstructor: Mr. Astoveza");
					DrawStarLine();
					Console.WriteLine("\nEnter to Back...");
					}
				else if (timeselector > 16 & timeselector <= 17){DrawStarLine();
					DrawStarLine();
				Console.WriteLine("Period Time: 4:00 - 5:00\nSubject: GEC 103 The Contemporary World\nSection & Year: BSIT 1-A\nInstructor: Mr. Acorda");
					DrawStarLine();
					Console.WriteLine("\nEnter to Back...");
					}
				else if (timeselector != MonmaxMenuItems){
					Console.WriteLine("NO SCHEDULE ASSIGN/Typing error (Press any key...)");
                            }
                else{
                    Console.WriteLine("Press any key...");
                }
                Console.ReadKey();
            }                    	        	
            }
            private static void WedRoom108(){
            const double MonmaxMenuItems = 25;
            double timeselector = 0;
            bool time = false;
            while (timeselector != MonmaxMenuItems){
                Console.Clear();
                	DrawStarLine();
                    Console.ForegroundColor = ConsoleColor.Green; Console.WriteLine("\t\t\t***WEDNESDAY***"); Console.ResetColor();
                    Console.WriteLine("\tInput Time now in 24 hours(Input 25 to Back): ");
					DrawStarLine();                    
                	time = double.TryParse(Console.ReadLine(), out timeselector);
					Console.Clear();
				if  (timeselector >= 7 & timeselector <= 9){
					DrawStarLine();
					Console.WriteLine("Period Time: 7:00 - 9:00\nSubject: SHA TECH 2\nSection & Year: Grade 11 (HUMS)\nInstructor: Mr. R. Diaz");
					DrawStarLine();
					Console.WriteLine("\nEnter to Back...");
                }
				else if (timeselector >= 10.5 & timeselector <= 13){
					DrawStarLine();
					Console.WriteLine("Period Time: 10:30 - 1:00\nSubject: ICT\nSection & Year: BSOA 1-C\nInstructor: Mr. R. Diaz");
					DrawStarLine();
					Console.WriteLine("\nEnter to Back...");
                }
				else if (timeselector > 13 & timeselector <= 14.5){
					DrawStarLine();
					Console.WriteLine("Period Time: 1:00 - 2:30\nSubject: GEC 102 Reading in Phil. History\nSection & Year: BSCS 1-A\nInstructor: Mr. Lacao-cao");
					DrawStarLine();
					Console.WriteLine("\nEnter to Back...");
                }
				else if (timeselector > 14.5 & timeselector <= 17){
					DrawStarLine();
					Console.WriteLine("Period Time: 2:30 - 5:00\nSubject: ITEC 206 Computer Organization\nSection & Year: BSIT 2-A\nInstructor: Mr. R. Diaz");
					DrawStarLine();
					Console.WriteLine("\nEnter to Back...");
                }
				else if(timeselector != MonmaxMenuItems){
					Console.WriteLine("NO SCHEDULE ASSIGN/Typing error (Press any key...)");
                            }
                else{
                    Console.WriteLine("Press any key...");
                }
                Console.ReadKey();
            }                    	         	
            }
            private static void ThuRoom108(){
            const double MonmaxMenuItems = 25;
            double timeselector = 0;
            bool time = false;
            while (timeselector != MonmaxMenuItems){
                Console.Clear();
                	DrawStarLine();
                    Console.ForegroundColor = ConsoleColor.Green; Console.WriteLine("\t\t\t***THURSDAY***"); Console.ResetColor();
                    Console.WriteLine("\tInput Time now in 24 hours(Input 25 to Back): ");
					DrawStarLine();                    
                	time = double.TryParse(Console.ReadLine(), out timeselector);
					Console.Clear();
				if  (timeselector >= 7 & timeselector <= 9.5){
					DrawStarLine();
					Console.WriteLine("Period Time: 7:00 - 9:30\nSubject: SHA TECH 2\nSection & Year: Grade 11 (HUMS)\nInstructor: Mr. R. Diaz");
					DrawStarLine();
					Console.WriteLine("\nEnter to Back...");
                }
				else if (timeselector > 9.5 & timeselector <= 12){
					DrawStarLine();
					Console.WriteLine("Period Time: 9:30 - 12:00\nSubject: SHS MIL 12\nSection & Year: Grade 12 (HUMS)\nInstructor: Mr. R. Diaz");
					DrawStarLine();
					Console.WriteLine("\nEnter to Back...");
                }
				else if (timeselector >= 13 & timeselector <= 15){
					DrawStarLine();
					Console.WriteLine("Period Time: 1:00 - 3:00\nSubject: ITEC 101\nSection & Year: BSIT 1-C\nInstructor: Ms. Mortel");
					DrawStarLine();
					Console.WriteLine("\nEnter to Back...");
                }
				else if (timeselector > 15 & timeselector <= 17){
					DrawStarLine();
					Console.WriteLine("Period Time: 3:00 - 5:00\nSubject: SHA TECH 2\nSection & Year: Grade 11 (ABM)\nInstructor: Mr. R. Diaz");
					DrawStarLine();
					Console.WriteLine("\nEnter to Back...");
                }
				else if(timeselector != MonmaxMenuItems){
					Console.WriteLine("NO SCHEDULE ASSIGN/Typing error (Press any key...)");
                            }
                else{
                    Console.WriteLine("Press any key...");
                }
                Console.ReadKey();
            }                    	      	
            }
            private static void FriRoom108()
            {
            const double MonmaxMenuItems = 25;
            double timeselector = 0;
            bool time = false;
            while (timeselector != MonmaxMenuItems){
                Console.Clear();
                	DrawStarLine();
                    Console.ForegroundColor = ConsoleColor.Green; Console.WriteLine("\t\t\t***FRIDAY***"); Console.ResetColor();
                    Console.WriteLine("\tInput Time now in 24 hours(Input 25 to Back): ");
					DrawStarLine();                    
                	time = double.TryParse(Console.ReadLine(), out timeselector);
					Console.Clear();
				if  (timeselector >= 7.5 & timeselector <= 10){
					DrawStarLine();
					Console.WriteLine("Period Time: 7:30 - 10:00\nSubject: SHA TECH 2\nSection & Year: Grade 11 (HUMS)\nInstructor: Mr. R. Diaz");
					DrawStarLine();
					Console.WriteLine("\nEnter to Back...");
                }
				else if(timeselector != MonmaxMenuItems){
					Console.WriteLine("NO SCHEDULE ASSIGN/Typing error (Press any key...)");
                            }
                else{
                    Console.WriteLine("Press any key...");
                }
                Console.ReadKey();
            }                    	
                    	
            }
            private static void AWRoom108(){
            Console.Clear();
            DrawStarLine();
            Console.ForegroundColor = ConsoleColor.Green; Console.WriteLine("\t\t**********CCS VOAG ROOM 108 ALL WEEK SCHEDULE**********\n"); Console.ResetColor();
			Console.WriteLine("\tMONDAY\nPeriod Time: 7:30 - 10:30\nSubject: ICT\nSection & Year: BSP 1-B\nInstructor: Ms. Zerah Mortel\nPeriod Time: 10:30 - 12:00\nSubject: ITEC 101 Intro. to Computing\nSection & Year: BSCS 1-A\nInstructor: Ms. Zerah Mortel\nPeriod Time: 12:30 - 3:30\nSubject: ICT\nSection & Year: BSOA 1-C\nInstructor: Mr. R. Diaz\nPeriod Time: 3:30 - 5:00\nSubject: ITEP 310\nSection & Year: BSIT 3-B\nInstructor: Mr. De Lucio");
			DrawStarLine();
			Console.WriteLine("\tTUESDAY\nPeriod Time: 7:00 - 9:00\nSubject: SHS MIL 12\nSection & Year: Grade 12 (HUMS)\nInstructor: Mr. R. Diaz\nPeriod Time: 10:00 - 12:30\nSubject: COMTECH Introduction to Computer Science\nSection & Year: BSAB 1\nInstructor: Mr. Gustilo ll\nPeriod Time: 1:00 - 2:00\nSubject: ITEC 101\nSection & Year: BSIT 1-B\nInstructor: Ms. Mortel\nPeriod Time: 2:00 - 3:00\nSubject: ITEC 101\nSection & Year: BSIT 1-C\nInstructor: Ms. Mortel\nPeriod Time: 3:00 - 4:00\nSubject: ITEC 101\nSection & Year: BSIT 1-E\nInstructor: Mr. Astoveza\nPeriod Time: 4:00 - 5:00\nSubject: GEC 103 The Contemporary World\nSection & Year: BSIT 1-A\nInstructor: Mr. Acorda");
			DrawStarLine();
			Console.WriteLine("\tWEDNESDAY\nPeriod Time: 7:00 - 9:00\nSubject: SHA TECH 2\nSection & Year: Grade 11 (HUMS)\nInstructor: Mr. R. Diaz\nPeriod Time: 10:30 - 1:00\nSubject: ICT\nSection & Year: BSOA 1-C\nInstructor: Mr. R. Diaz\nPeriod Time: 1:00 - 2:30\nSubject: GEC 102 Reading in Phil. History\nSection & Year: BSCS 1-A\nInstructor: Mr. Lacao-cao\nPeriod Time: 2:30 - 5:00\nSubject: ITEC 206 Computer Organization\nSection & Year: BSIT 2-A\nInstructor: Mr. R. Diaz");
			DrawStarLine();
			Console.WriteLine("\tTHURSDAY\nPeriod Time: 7:00 - 9:30\nSubject: SHA TECH 2\nSection & Year: Grade 11 (HUMS)\nInstructor: Mr. R. Diaz\nPeriod Time: 9:30 - 12:00\nSubject: SHS MIL 12\nSection & Year: Grade 12 (HUMS)\nInstructor: Mr. R. Diaz\nPeriod Time: 1:00 - 3:00\nSubject: ITEC 101\nSection & Year: BSIT 1-C\nInstructor: Ms. Mortel\nPeriod Time: 3:00 - 5:00\nSubject: SHA TECH 2\nSection & Year: Grade 11 (ABM)\nInstructor: Mr. R. Diaz");
			DrawStarLine();
			Console.WriteLine("\tFRIDAY\nPeriod Time: 7:30 - 10:00\nSubject: SHA TECH 2\nSection & Year: Grade 11 (HUMS)\nInstructor: Mr. R. Diaz");
            DrawStarLine();
            Console.WriteLine("\nPress any key..");
            }
        //ROOM 201 INFO.
        private static void DisplayRoom201(){
            const int maxMenuItems = 7;
            int selector = 0;
            bool good = false;
            while (selector != maxMenuItems){
                Console.Clear();
                DrawStarLine();
                    Console.ForegroundColor = ConsoleColor.Green; Console.WriteLine("\t\t***CCS VOAG ROOM 201 SCHEDULE***"); Console.ResetColor();
                DrawStarLine();
                DrawMenu201(maxMenuItems);
                //user input
                good = int.TryParse(Console.ReadLine(), out selector);
                if (good){
					switch (selector){
                        case 1:
							MonRoom201();
							break;
                        case 2:
                            TueRoom201();
                            break;
                        case 3:
                            WedRoom201();
                            break;
                        case 4:
                            ThuRoom201();
                            break;
                        case 5:
                            FriRoom201();
                            break;
                        case 6:
                            AWRoom201();
                            break;                            
                        default:
                            if (selector != maxMenuItems)
                            { ErrorMessage();
                         } break;
                    }
                }
                else
                { ErrorMessage();
                } Console.ReadKey();
            }
            }
            private static void DrawMenu201(int maxitems){ 
            Console.WriteLine("[1] = Monday\n[2] = Tuesday\n[3] = Wednesday\n[4] = Thursday\n[5] = Friday\n[6] = All Week Schedule");
            DrawStarLine();
            Console.ForegroundColor = ConsoleColor.DarkGray; Console.WriteLine("  Make your choice: type 1, 2,... or {0} Go Back to Room Choices", maxitems); Console.ResetColor();
            DrawStarLine();
            }
            private static void MonRoom201(){
            const double MonmaxMenuItems = 25;
            double timeselector = 0;
            bool time = false;
            while (timeselector != MonmaxMenuItems){
                Console.Clear();
                	DrawStarLine();
                    Console.ForegroundColor = ConsoleColor.Green; Console.WriteLine("\t\t\t***MONDAY***"); Console.ResetColor();
                    Console.WriteLine("\tInput Time now in 24 hours(Input 25 to Back): ");
					DrawStarLine();                    
                	time = double.TryParse(Console.ReadLine(), out timeselector);
					Console.Clear();
				if  (timeselector >= 7.5 & timeselector <= 9.5){
					DrawStarLine();
					Console.WriteLine("");
					DrawStarLine();
					Console.WriteLine("\nEnter to Back...");
                }
				else if (timeselector > 9.5 & timeselector <= 12){
					DrawStarLine();
					Console.WriteLine("");
					DrawStarLine();
					Console.WriteLine("\nEnter to Back...");
                }
				else if (timeselector >= 13 & timeselector <= 16){
					DrawStarLine();
					Console.WriteLine("");
					DrawStarLine();
					Console.WriteLine("\nEnter to Back...");
                }
				else if(timeselector != MonmaxMenuItems){
					Console.WriteLine("NO SCHEDULE ASSIGN/Typing error (Press any key...)");
                            }
                else{
                    Console.WriteLine("Press any key...");
                }
                Console.ReadKey();
            }                    	       	
            }
            private static void TueRoom201(){
            const double MonmaxMenuItems = 25;
            double timeselector = 0;
            bool time = false;
            while (timeselector != MonmaxMenuItems){
                Console.Clear();
                DrawStarLine();
                    	Console.ForegroundColor = ConsoleColor.Green; Console.WriteLine("\t\t\t***TUESDAY***"); Console.ResetColor();
                    	Console.WriteLine("\tInput Time now in 24 hours(Input 25 to Back): ");  DrawStarLine();
                time = double.TryParse(Console.ReadLine(), out timeselector);
				if (timeselector >= 8 && timeselector <= 10){
					Console.WriteLine("");
					DrawStarLine();
					Console.WriteLine("\nEnter to Back...");
                }
				else if (timeselector > 10 && timeselector <= 12){
					Console.WriteLine("");
					DrawStarLine();
					Console.WriteLine("\nEnter to Back...");
                }
				else if (timeselector >= 13 && timeselector <= 14){
					Console.WriteLine("");
					DrawStarLine();
					Console.WriteLine("\nEnter to Back...");
                }
				else if (timeselector != MonmaxMenuItems){
					Console.WriteLine("NO SCHEDULE ASSIGN/Typing error (Press any key...)");
                            }
                else{
                    Console.WriteLine("Press any key...");
                }
                Console.ReadKey();
            }                    	        	
            }
            private static void WedRoom201(){
            const double MonmaxMenuItems = 25;
            double timeselector = 0;
            bool time = false;
            while (timeselector != MonmaxMenuItems){
                Console.Clear();
                	DrawStarLine();
                    Console.ForegroundColor = ConsoleColor.Green; Console.WriteLine("\t\t\t***WEDNESDAY***"); Console.ResetColor();
                    Console.WriteLine("\tInput Time now in 24 hours(Input 25 to Back): ");
					DrawStarLine();                    
                	time = double.TryParse(Console.ReadLine(), out timeselector);
					Console.Clear();
				if  (timeselector >= 7.5 & timeselector <= 10.5){
					DrawStarLine();
					Console.WriteLine("");
					DrawStarLine();
					Console.WriteLine("\nEnter to Back...");
                }
				else if (timeselector > 10.5 & timeselector <= 11.5){
					DrawStarLine();
					Console.WriteLine("");
					DrawStarLine();
					Console.WriteLine("\nEnter to Back...");
                }
				else if (timeselector >= 12 & timeselector <= 13){
					DrawStarLine();
					Console.WriteLine("");
					DrawStarLine();
					Console.WriteLine("\nEnter to Back...");
                }
				else if (timeselector >= 14.5 & timeselector <= 15){
					DrawStarLine();
					Console.WriteLine("");
					DrawStarLine();
					Console.WriteLine("\nEnter to Back...");
                }
				else if(timeselector != MonmaxMenuItems){
					Console.WriteLine("NO SCHEDULE ASSIGN/Typing error (Press any key...)");
                            }
                else{
                    Console.WriteLine("Press any key...");
                }
                Console.ReadKey();
            }                    	         	
            }
            private static void ThuRoom201(){
            const double MonmaxMenuItems = 25;
            double timeselector = 0;
            bool time = false;
            while (timeselector != MonmaxMenuItems){
                Console.Clear();
                	DrawStarLine();
                    Console.ForegroundColor = ConsoleColor.Green; Console.WriteLine("\t\t\t***THURSDAY***"); Console.ResetColor();
                    Console.WriteLine("\tInput Time now in 24 hours(Input 25 to Back): ");
					DrawStarLine();                    
                	time = double.TryParse(Console.ReadLine(), out timeselector);
					Console.Clear();
				if  (timeselector >= 8 & timeselector <= 9.5){
					DrawStarLine();
					Console.WriteLine("");
					DrawStarLine();
					Console.WriteLine("\nEnter to Back...");
                }
				else if (timeselector >= 10 & timeselector <= 13){
					DrawStarLine();
					Console.WriteLine("");
					DrawStarLine();
					Console.WriteLine("\nEnter to Back...");
                }
				else if (timeselector >= 13.5 & timeselector <= 14){
					DrawStarLine();
					Console.WriteLine("");
					DrawStarLine();
					Console.WriteLine("\nEnter to Back...");
                }
				else if (timeselector > 14 & timeselector <= 16){
					DrawStarLine();
					Console.WriteLine("");
					DrawStarLine();
					Console.WriteLine("\nEnter to Back...");
                }
				else if(timeselector != MonmaxMenuItems){
					Console.WriteLine("NO SCHEDULE ASSIGN/Typing error (Press any key...)");
                            }
                else{
                    Console.WriteLine("Press any key...");
                }
                Console.ReadKey();
            }                    	      	
            }
            private static void FriRoom201()
            {
            const double MonmaxMenuItems = 25;
            double timeselector = 0;
            bool time = false;
            while (timeselector != MonmaxMenuItems){
                Console.Clear();
                	DrawStarLine();
                    Console.ForegroundColor = ConsoleColor.Green; Console.WriteLine("\t\t\t***FRIDAY***"); Console.ResetColor();
                    Console.WriteLine("\tInput Time now in 24 hours(Input 25 to Back): ");
					DrawStarLine();                    
                	time = double.TryParse(Console.ReadLine(), out timeselector);
					Console.Clear();
				if  (timeselector >= 10 & timeselector <= 11.5){
					DrawStarLine();
					Console.WriteLine("");
					DrawStarLine();
					Console.WriteLine("\nEnter to Back...");
                }
				else if (timeselector >= 15 & timeselector <= 16){
					DrawStarLine();
					Console.WriteLine("");
					DrawStarLine();
					Console.WriteLine("\nEnter to Back...");
                }
				else if(timeselector != MonmaxMenuItems){
					Console.WriteLine("NO SCHEDULE ASSIGN/Typing error (Press any key...)");
                            }
                else{
                    Console.WriteLine("Press any key...");
                }
                Console.ReadKey();
            }                    	
                    	
            }
            private static void AWRoom201(){
            Console.Clear();
            DrawStarLine();
            Console.ForegroundColor = ConsoleColor.Green; Console.WriteLine("\t\t**********CCS VOAG ROOM 201 ALL WEEK SCHEDULE**********\n"); Console.ResetColor();
			Console.WriteLine("\tMONDAY\n");
			DrawStarLine();
			Console.WriteLine("\tTUESDAY\n");
			DrawStarLine();
			Console.WriteLine("\tWEDNESDAY\n");
			DrawStarLine();
			Console.WriteLine("\tTHURSDAY\n");
			DrawStarLine();
			Console.WriteLine("\tFRIDAY\n");
            DrawStarLine();
            Console.WriteLine("\nPress any key..");
            }
        //ROOM 202 INFO.
        private static void DisplayRoom202(){
            const int maxMenuItems = 7;
            int selector = 0;
            bool good = false;
            while (selector != maxMenuItems){
                Console.Clear();
                DrawStarLine();
                    Console.ForegroundColor = ConsoleColor.Green; Console.WriteLine("\t\t***CCS VOAG ROOM 202 SCHEDULE***"); Console.ResetColor();
                DrawStarLine();
                DrawMenu202(maxMenuItems);
                //user input
                good = int.TryParse(Console.ReadLine(), out selector);
                if (good){
					switch (selector){
                        case 1:
							MonRoom202();
							break;
                        case 2:
                            TueRoom202();
                            break;
                        case 3:
                            WedRoom202();
                            break;
                        case 4:
                            ThuRoom202();
                            break;
                        case 5:
                            FriRoom202();
                            break;
                        case 6:
                            AWRoom202();
                            break;                            
                        default:
                            if (selector != maxMenuItems)
                            { ErrorMessage();
                         } break;
                    }
                }
                else
                { ErrorMessage();
                } Console.ReadKey();
            }
            }
            private static void DrawMenu202(int maxitems){ 
            Console.WriteLine("[1] = Monday\n[2] = Tuesday\n[3] = Wednesday\n[4] = Thursday\n[5] = Friday\n[6] = All Week Schedule");
            DrawStarLine();
            Console.ForegroundColor = ConsoleColor.DarkGray; Console.WriteLine("  Make your choice: type 1, 2,... or {0} Go Back to Room Choices", maxitems); Console.ResetColor();
            DrawStarLine();
            }
            private static void MonRoom202(){
            const double MonmaxMenuItems = 25;
            double timeselector = 0;
            bool time = false;
            while (timeselector != MonmaxMenuItems){
                Console.Clear();
                	DrawStarLine();
                    Console.ForegroundColor = ConsoleColor.Green; Console.WriteLine("\t\t\t***MONDAY***"); Console.ResetColor();
                    Console.WriteLine("\tInput Time now in 24 hours(Input 25 to Back): ");
					DrawStarLine();                    
                	time = double.TryParse(Console.ReadLine(), out timeselector);
					Console.Clear();
				if  (timeselector >= 7.5 & timeselector <= 9.5){
					DrawStarLine();
					Console.WriteLine("");
					DrawStarLine();
					Console.WriteLine("\nEnter to Back...");
                }
				else if (timeselector > 9.5 & timeselector <= 12){
					DrawStarLine();
					Console.WriteLine("");
					DrawStarLine();
					Console.WriteLine("\nEnter to Back...");
                }
				else if (timeselector >= 13 & timeselector <= 16){
					DrawStarLine();
					Console.WriteLine("");
					DrawStarLine();
					Console.WriteLine("\nEnter to Back...");
                }
				else if(timeselector != MonmaxMenuItems){
					Console.WriteLine("NO SCHEDULE ASSIGN/Typing error (Press any key...)");
                            }
                else{
                    Console.WriteLine("Press any key...");
                }
                Console.ReadKey();
            }                    	       	
            }
            private static void TueRoom202(){
            const double MonmaxMenuItems = 25;
            double timeselector = 0;
            bool time = false;
            while (timeselector != MonmaxMenuItems){
                Console.Clear();
                DrawStarLine();
                    	Console.ForegroundColor = ConsoleColor.Green; Console.WriteLine("\t\t\t***TUESDAY***"); Console.ResetColor();
                    	Console.WriteLine("\tInput Time now in 24 hours(Input 25 to Back): ");  DrawStarLine();
                time = double.TryParse(Console.ReadLine(), out timeselector);
				if (timeselector >= 8 && timeselector <= 10){
					Console.WriteLine("");
					DrawStarLine();
					Console.WriteLine("\nEnter to Back...");
                }
				else if (timeselector > 10 && timeselector <= 12){
					Console.WriteLine("");
					DrawStarLine();
					Console.WriteLine("\nEnter to Back...");
                }
				else if (timeselector >= 13 && timeselector <= 14){
					Console.WriteLine("");
					DrawStarLine();
					Console.WriteLine("\nEnter to Back...");
                }
				else if (timeselector != MonmaxMenuItems){
					Console.WriteLine("NO SCHEDULE ASSIGN/Typing error (Press any key...)");
                            }
                else{
                    Console.WriteLine("Press any key...");
                }
                Console.ReadKey();
            }                    	        	
            }
            private static void WedRoom202(){
            const double MonmaxMenuItems = 25;
            double timeselector = 0;
            bool time = false;
            while (timeselector != MonmaxMenuItems){
                Console.Clear();
                	DrawStarLine();
                    Console.ForegroundColor = ConsoleColor.Green; Console.WriteLine("\t\t\t***WEDNESDAY***"); Console.ResetColor();
                    Console.WriteLine("\tInput Time now in 24 hours(Input 25 to Back): ");
					DrawStarLine();                    
                	time = double.TryParse(Console.ReadLine(), out timeselector);
					Console.Clear();
				if  (timeselector >= 7.5 & timeselector <= 10.5){
					DrawStarLine();
					Console.WriteLine("");
					DrawStarLine();
					Console.WriteLine("\nEnter to Back...");
                }
				else if (timeselector > 10.5 & timeselector <= 11.5){
					DrawStarLine();
					Console.WriteLine("");
					DrawStarLine();
					Console.WriteLine("\nEnter to Back...");
                }
				else if (timeselector >= 12 & timeselector <= 13){
					DrawStarLine();
					Console.WriteLine("");
					DrawStarLine();
					Console.WriteLine("\nEnter to Back...");
                }
				else if (timeselector >= 14.5 & timeselector <= 15){
					DrawStarLine();
					Console.WriteLine("");
					DrawStarLine();
					Console.WriteLine("\nEnter to Back...");
                }
				else if(timeselector != MonmaxMenuItems){
					Console.WriteLine("NO SCHEDULE ASSIGN/Typing error (Press any key...)");
                            }
                else{
                    Console.WriteLine("Press any key...");
                }
                Console.ReadKey();
            }                    	         	
            }
            private static void ThuRoom202(){
            const double MonmaxMenuItems = 25;
            double timeselector = 0;
            bool time = false;
            while (timeselector != MonmaxMenuItems){
                Console.Clear();
                	DrawStarLine();
                    Console.ForegroundColor = ConsoleColor.Green; Console.WriteLine("\t\t\t***THURSDAY***"); Console.ResetColor();
                    Console.WriteLine("\tInput Time now in 24 hours(Input 25 to Back): ");
					DrawStarLine();                    
                	time = double.TryParse(Console.ReadLine(), out timeselector);
					Console.Clear();
				if  (timeselector >= 8 & timeselector <= 9.5){
					DrawStarLine();
					Console.WriteLine("");
					DrawStarLine();
					Console.WriteLine("\nEnter to Back...");
                }
				else if (timeselector >= 10 & timeselector <= 13){
					DrawStarLine();
					Console.WriteLine("");
					DrawStarLine();
					Console.WriteLine("\nEnter to Back...");
                }
				else if (timeselector >= 13.5 & timeselector <= 14){
					DrawStarLine();
					Console.WriteLine("");
					DrawStarLine();
					Console.WriteLine("\nEnter to Back...");
                }
				else if (timeselector > 14 & timeselector <= 16){
					DrawStarLine();
					Console.WriteLine("");
					DrawStarLine();
					Console.WriteLine("\nEnter to Back...");
                }
				else if(timeselector != MonmaxMenuItems){
					Console.WriteLine("NO SCHEDULE ASSIGN/Typing error (Press any key...)");
                            }
                else{
                    Console.WriteLine("Press any key...");
                }
                Console.ReadKey();
            }                    	      	
            }
            private static void FriRoom202()
            {
            const double MonmaxMenuItems = 25;
            double timeselector = 0;
            bool time = false;
            while (timeselector != MonmaxMenuItems){
                Console.Clear();
                	DrawStarLine();
                    Console.ForegroundColor = ConsoleColor.Green; Console.WriteLine("\t\t\t***FRIDAY***"); Console.ResetColor();
                    Console.WriteLine("\tInput Time now in 24 hours(Input 25 to Back): ");
					DrawStarLine();                    
                	time = double.TryParse(Console.ReadLine(), out timeselector);
					Console.Clear();
				if  (timeselector >= 10 & timeselector <= 11.5){
					DrawStarLine();
					Console.WriteLine("");
					DrawStarLine();
					Console.WriteLine("\nEnter to Back...");
                }
				else if (timeselector >= 15 & timeselector <= 16){
					DrawStarLine();
					Console.WriteLine("");
					DrawStarLine();
					Console.WriteLine("\nEnter to Back...");
                }
				else if(timeselector != MonmaxMenuItems){
					Console.WriteLine("NO SCHEDULE ASSIGN/Typing error (Press any key...)");
                            }
                else{
                    Console.WriteLine("Press any key...");
                }
                Console.ReadKey();
            }                    	
                    	
            }
            private static void AWRoom202(){
            Console.Clear();
            DrawStarLine();
            Console.ForegroundColor = ConsoleColor.Green; Console.WriteLine("\t\t**********CCS VOAG ROOM 202 ALL WEEK SCHEDULE**********\n"); Console.ResetColor();
			Console.WriteLine("\tMONDAY\n");
			DrawStarLine();
			Console.WriteLine("\tTUESDAY\n");
			DrawStarLine();
			Console.WriteLine("\tWEDNESDAY\n");
			DrawStarLine();
			Console.WriteLine("\tTHURSDAY\n");
			DrawStarLine();
			Console.WriteLine("\tFRIDAY\n");
            DrawStarLine();
            Console.WriteLine("\nPress any key..");
            }
        //ROOM 203 INFO.
        private static void DisplayRoom203(){
            const int maxMenuItems = 7;
            int selector = 0;
            bool good = false;
            while (selector != maxMenuItems){
                Console.Clear();
                DrawStarLine();
                    Console.ForegroundColor = ConsoleColor.Green; Console.WriteLine("\t\t***CCS VOAG ROOM 203 SCHEDULE***"); Console.ResetColor();
                DrawStarLine();
                DrawMenu203(maxMenuItems);
                //user input
                good = int.TryParse(Console.ReadLine(), out selector);
                if (good){
					switch (selector){
                        case 1:
							MonRoom203();
							break;
                        case 2:
                            TueRoom203();
                            break;
                        case 3:
                            WedRoom203();
                            break;
                        case 4:
                            ThuRoom203();
                            break;
                        case 5:
                            FriRoom203();
                            break;
                        case 6:
                            AWRoom203();
                            break;                            
                        default:
                            if (selector != maxMenuItems)
                            { ErrorMessage();
                         } break;
                    }
                }
                else
                { ErrorMessage();
                } Console.ReadKey();
            }
            }
            private static void DrawMenu203(int maxitems){ 
            Console.WriteLine("[1] = Monday\n[2] = Tuesday\n[3] = Wednesday\n[4] = Thursday\n[5] = Friday\n[6] = All Week Schedule");
            DrawStarLine();
            Console.ForegroundColor = ConsoleColor.DarkGray; Console.WriteLine("  Make your choice: type 1, 2,... or {0} Go Back to Room Choices", maxitems); Console.ResetColor();
            DrawStarLine();
            }
            private static void MonRoom203(){
            const double MonmaxMenuItems = 25;
            double timeselector = 0;
            bool time = false;
            while (timeselector != MonmaxMenuItems){
                Console.Clear();
                	DrawStarLine();
                    Console.ForegroundColor = ConsoleColor.Green; Console.WriteLine("\t\t\t***MONDAY***"); Console.ResetColor();
                    Console.WriteLine("\tInput Time now in 24 hours(Input 25 to Back): ");
					DrawStarLine();                    
                	time = double.TryParse(Console.ReadLine(), out timeselector);
					Console.Clear();
				if  (timeselector >= 7 & timeselector <= 8){
					DrawStarLine();
					Console.WriteLine("eriod Time: 7:00 - 8:00\nSubject: ITEP 309 Objected Oriented Programming\nSection&Year: BSIT 3-B\nInstructor: A. Dela Torre");
					DrawStarLine();
					Console.WriteLine("\nEnter to Back...");
                }
				else if (timeselector >= 10 & timeselector <= 11){
					DrawStarLine();
					Console.WriteLine("Period Time: 10:00 - 11:00\nSubject: ITEP 312\nSection&Year: BSIT 3-B\nInstructor: Mr. Santeliees");
					DrawStarLine();
					Console.WriteLine("\nEnter to Back...");
                }
				else if (timeselector > 11 & timeselector <= 12){
					DrawStarLine();
					Console.WriteLine("Period Time: 11:00 - 12:00\nSubject: ITEP 311\nSection&Year: BSIT 3-A\nInstructor: Mr. Astoveza");
					DrawStarLine();
					Console.WriteLine("\nEnter to Back...");
                }
				else if (timeselector >= 13 & timeselector <= 16){
					DrawStarLine();
				Console.WriteLine("Period Time: 1:00 -4:00\nSubject: ITEP 309 Objected Oriented Programming\nSection&Year: BSIT 3-A\nInstructor: A. Dela Torre");
					DrawStarLine();
					Console.WriteLine("\nEnter to Back...");
					}
				else if (timeselector > 16 & timeselector <= 17){
					DrawStarLine();
				Console.WriteLine("Period Time: 4:00 - 5:00\nSubject: ITEP 312\nSection&Year: BSIT 3-A\nInstructor: Mr. Santeliees");
					DrawStarLine();
					Console.WriteLine("\nEnter to Back...");
					}
				else if(timeselector != MonmaxMenuItems){
					Console.WriteLine("NO SCHEDULE ASSIGN/Typing error (Press any key...)");
                            }
                else{
                    Console.WriteLine("Press any key...");
                }
                Console.ReadKey();
            }                    	       	
            }
            private static void TueRoom203(){
            const double MonmaxMenuItems = 25;
            double timeselector = 0;
            bool time = false;
            while (timeselector != MonmaxMenuItems){
                Console.Clear();
                DrawStarLine();
                    	Console.ForegroundColor = ConsoleColor.Green; Console.WriteLine("\t\t\t***TUESDAY***"); Console.ResetColor();
                    	Console.WriteLine("\tInput Time now in 24 hours(Input 25 to Back): "); DrawStarLine();
                time = double.TryParse(Console.ReadLine(), out timeselector);
                Console.Clear();
				if (timeselector >= 7 && timeselector <= 10){DrawStarLine();
					Console.WriteLine("Period Time: 7:00 - 10:00\nSubject: ITEP 309 Object Oriented Programming\nSection&Year: BSIT 3-B\nInstructor: A. Dela Torre");
					DrawStarLine();
					Console.WriteLine("\nEnter to Back...");
                }
				else if (timeselector > 10 && timeselector <= 13){DrawStarLine();
					Console.WriteLine("Period Time: 10:00 - 1:00\nSubject: Reading in Philippine History\nSection&Year: BSIT I-A\nInstructor: Mr. Lacao-cao");
					DrawStarLine();
					Console.WriteLine("\nEnter to Back...");
                }
				else if (timeselector >= 14 && timeselector <= 16){DrawStarLine();
					Console.WriteLine("Period Time: 2:00 - 5:00\nSubject: Web Development\nSection&Year: BSIT 3-C\nInstructor: Mr. Santeliees");
					DrawStarLine();
					Console.WriteLine("\nEnter to Back...");
                }
				else if (timeselector != MonmaxMenuItems){
					Console.WriteLine("NO SCHEDULE ASSIGN/Typing error (Press any key...)");
                            }
                else{
                    Console.WriteLine("Press any key...");
                }
                Console.ReadKey();
            }                    	        	
            }
            private static void WedRoom203(){
            const double MonmaxMenuItems = 25;
            double timeselector = 0;
            bool time = false;
            while (timeselector != MonmaxMenuItems){
                Console.Clear();
                	DrawStarLine();
                    Console.ForegroundColor = ConsoleColor.Green; Console.WriteLine("\t\t\t***WEDNESDAY***"); Console.ResetColor();
                    Console.WriteLine("\tInput Time now in 24 hours(Input 25 to Back): ");
					DrawStarLine();                    
                	time = double.TryParse(Console.ReadLine(), out timeselector);
					Console.Clear();
				if  (timeselector >= 7 & timeselector <= 9.5){
					DrawStarLine();
					Console.WriteLine("Period Time: 7:00 - 9:30\nSubject: Objected Oriented Programming\nSection&Year: ACT 2-A\nInstructor: A. Dela Torre");
					DrawStarLine();
					Console.WriteLine("\nEnter to Back...");
                }
				else if (timeselector > 9.5 & timeselector <= 10.5){
					DrawStarLine();
					Console.WriteLine("Period Time: 9:50 - 10:30\nSubject: ITEC 208\nSection&Year: BSIT 2-A\nInstructor: A. Dela Torre ");
					DrawStarLine();
					Console.WriteLine("\nEnter to Back...");
                }
				else if (timeselector >= 11 & timeselector <= 12){
					DrawStarLine();
					Console.WriteLine("Period Time: 11:00 - 12:00\nSubject: SOCS 3\nSection&Year: BSIT 3-B\nInstructor: Mr. Lacao-cao");
					DrawStarLine();
					Console.WriteLine("\nEnter to Back...");
                }
				else if (timeselector > 12 & timeselector <= 15){
					DrawStarLine();
					Console.WriteLine("Period Time: 12:00 - 3:00\nSubject: System Analysis and Designs\nSection&Year: BSIT 3-A\nInstructor: A. De Luna");
					DrawStarLine();
					Console.WriteLine("\nEnter to Back...");
                }
				else if (timeselector > 15 & timeselector <= 17){
					DrawStarLine();
				Console.WriteLine("Period Time: 3:00 - 5:00\nSubject: Web Development\nSection&Year: BSIT 3-A\nInstructor: Mr. Santeliees");
					DrawStarLine();
					Console.WriteLine("\nEnter to Back...");
					}
				else if(timeselector != MonmaxMenuItems){
					Console.WriteLine("NO SCHEDULE ASSIGN/Typing error (Press any key...)");
                            }
                else{
                    Console.WriteLine("Press any key...");
                }
                Console.ReadKey();
            }                    	         	
            }
            private static void ThuRoom203(){
            const double MonmaxMenuItems = 25;
            double timeselector = 0;
            bool time = false;
            while (timeselector != MonmaxMenuItems){
                Console.Clear();
                	DrawStarLine();
                    Console.ForegroundColor = ConsoleColor.Green; Console.WriteLine("\t\t\t***THURSDAY***"); Console.ResetColor();
                    Console.WriteLine("\tInput Time now in 24 hours(Input 25 to Back): ");
					DrawStarLine();                    
                	time = double.TryParse(Console.ReadLine(), out timeselector);
					Console.Clear();
				if  (timeselector >= 7 & timeselector <= 10.5){
					DrawStarLine();
					Console.WriteLine("Period Time: 7:00 - 10:30\nSubject: ITEP 11 Database Management System 2\nSection&Year: BSIT 3-A\nInstructor: Mr. Astoveza");
					DrawStarLine();
					Console.WriteLine("\nEnter to Back...");
                }
				else if (timeselector >= 13 & timeselector <= 17){
					DrawStarLine();
					Console.WriteLine("Period Time: 1:00 - 5:00\nSubject: ITEP 312 Web Development\nSection&Year: BSIT 3-A\nInstructor: N. Santeliees");
					DrawStarLine();
					Console.WriteLine("\nEnter to Back...");
                }
				else if(timeselector != MonmaxMenuItems){
					Console.WriteLine("NO SCHEDULE ASSIGN/Typing error (Press any key...)");
                            }
                else{
                    Console.WriteLine("Press any key...");
                }
                Console.ReadKey();
            }                    	      	
            }
            private static void FriRoom203()
            {
            const double MonmaxMenuItems = 25;
            double timeselector = 0;
            bool time = false;
            while (timeselector != MonmaxMenuItems){
                Console.Clear();
                	DrawStarLine();
                    Console.ForegroundColor = ConsoleColor.Green; Console.WriteLine("\t\t\t***FRIDAY***"); Console.ResetColor();
                    Console.WriteLine("\tInput Time now in 24 hours(Input 25 to Back): ");
					DrawStarLine();                    
                	time = double.TryParse(Console.ReadLine(), out timeselector);
					Console.Clear();
				if  (timeselector >= 7 & timeselector <= 8){
					DrawStarLine();
					Console.WriteLine("Period Time: 7:00 - 12:00\nSubject: ITEP 311 Database Management Systen 2\nSection&Year: BSIT 3-B\nInstructor: Mr. Astoveza");
					DrawStarLine();
					Console.WriteLine("\nEnter to Back...");
                }
				else if (timeselector >= 12 & timeselector <= 17){
					DrawStarLine();
					Console.WriteLine("Period Time: 12:00 - 5:00\nSubject: ITEP 311 Database Management System 2\nSection&Year: BSIT 3-C\nInstructor: Mr. Astoveza");
					DrawStarLine();
					Console.WriteLine("\nEnter to Back...");
                }
				else if(timeselector != MonmaxMenuItems){
					Console.WriteLine("NO SCHEDULE ASSIGN/Typing error (Press any key...)");
                            }
                else{
                    Console.WriteLine("Press any key...");
                }
                Console.ReadKey();
            }                    	
                    	
            }
            private static void AWRoom203(){
            Console.Clear();
            DrawStarLine();
            Console.ForegroundColor = ConsoleColor.Green; Console.WriteLine("\t\t**********CCS VOAG ROOM 203 ALL WEEK SCHEDULE**********\n"); Console.ResetColor();
			Console.WriteLine("\tMONDAY\nPeriod Time: 7:00 - 8:00\nSubject: ITEP 309 Objected Oriented Programming\nSection&Year: BSIT 3-B\nInstructor: A. Dela Torre\nPeriod Time: 10:00 - 11:00\nSubject: ITEP 312\nSection&Year: BSIT 3-B\nInstructor: Mr. Santeliees\nPeriod Time: 11:00 - 12:00\nSubject: ITEP 311\nSection&Year: BSIT 3-A\nInstructor: Mr. Astoveza\nPeriod Time: 1:00 -4:00\nSubject: ITEP 309 Objected Oriented Programming\nSection&Year: BSIT 3-A\nInstructor: A. Dela Torre\nPeriod Time: 4:00 - 5:00\nSubject: ITEP 312\nSection&Year: BSIT 3-A\nInstructor: Mr. Santeliees");
			DrawStarLine();
			Console.WriteLine("\tTUESDAY\nPeriod Time: 7:00 - 10:00\nSubject: ITEP 309 Object Oriented Programming\nSection&Year: BSIT 3-B\nInstructor: A. Dela Torre\nPeriod Time: 10:00 - 1:00\nSubject: Reading in Philippine History\nSection&Year: BSIT I-A\nInstructor: Mr. Lacao-cao\nPeriod Time: 2:00 - 5:00\nSubject: Web Development\nSection&Year: BSIT 3-C\nInstructor: Mr. Santeliees");
			DrawStarLine();
			Console.WriteLine("\tWEDNESDAY\nPeriod Time: 7:00 - 9:30\nSubject: Objected Oriented Programming\nSection&Year: ACT 2-A\nInstructor: A. Dela Torre\nPeriod Time: 9:30 - 10:30\nSubject: ITEC 208\nSection&Year: BSIT 2-A\nInstructor: A. Dela Torre \nPeriod Time: 11:00 - 12:00\nSubject: SOCS 3\nSection&Year: BSIT 3-B\nInstructor: Mr. Lacao-cao\nPeriod Time: 12:00 - 3:00\nSubject: System Analysis and Designs\nSection&Year: BSIT 3-A\nInstructor: A. De Luna\nPeriod Time: 3:00 - 5:00\nSubject: Web Development\nSection&Year: BSIT 3-A\nInstructor: Mr. Santeliees");
			DrawStarLine();
			Console.WriteLine("\tTHURSDAY\nPeriod Time: 7:00 - 10:00\nSubject: ITEP 11 Database Management System 2\nSection&Year: BSIT 3-A\nInstructor: Mr. Astoveza\nPeriod Time: 1:00 - 5:00\nSubject: ITEP 312 Web Development\nSection&Year: BSIT 3-A\nInstructor: N. Santeliees");
			DrawStarLine();
			Console.WriteLine("\tFRIDAY\nPeriod Time: 7:00 - 12:00\nSubject: ITEP 311 Database Management Systen 2\nSection&Year: BSIT 3-B\nInstructor: Mr. Astoveza\nPeriod Time: 12:00 - 5:00\nSubject: ITEP 311 Database Management System 2\nSection&Year: BSIT 3-C\nInstructor: Mr. Astoveza");
            DrawStarLine();
            Console.WriteLine("\nPress any key..");
            }
        //ROOM 204 INFO.
        private static void DisplayRoom204(){
            const int maxMenuItems = 7;
            int selector = 0;
            bool good = false;
            while (selector != maxMenuItems){
                Console.Clear();
                DrawStarLine();
                    Console.ForegroundColor = ConsoleColor.Green; Console.WriteLine("\t\t***CCS VOAG ROOM 204 SCHEDULE***"); Console.ResetColor();
                DrawStarLine();
                DrawMenu204(maxMenuItems);
                //user input
                good = int.TryParse(Console.ReadLine(), out selector);
                if (good){
					switch (selector){
                        case 1:
							MonRoom204();
							break;
                        case 2:
                            TueRoom204();
                            break;
                        case 3:
                            WedRoom204();
                            break;
                        case 4:
                            ThuRoom204();
                            break;
                        case 5:
                            FriRoom204();
                            break;
                        case 6:
                            AWRoom204();
                            break;                            
                        default:
                            if (selector != maxMenuItems)
                            { ErrorMessage();
                         } break;
                    }
                }
                else
                { ErrorMessage();
                } Console.ReadKey();
            }
            }
            private static void DrawMenu204(int maxitems){ 
            Console.WriteLine("[1] = Monday\n[2] = Tuesday\n[3] = Wednesday\n[4] = Thursday\n[5] = Friday\n[6] = All Week Schedule");
            DrawStarLine();
            Console.ForegroundColor = ConsoleColor.DarkGray; Console.WriteLine("  Make your choice: type 1, 2,... or {0} Go Back to Room Choices", maxitems); Console.ResetColor();
            DrawStarLine();
            }
            private static void MonRoom204(){
            const double MonmaxMenuItems = 25;
            double timeselector = 0;
            bool time = false;
            while (timeselector != MonmaxMenuItems){
                Console.Clear();
                	DrawStarLine();
                    Console.ForegroundColor = ConsoleColor.Green; Console.WriteLine("\t\t\t***MONDAY***"); Console.ResetColor();
                    Console.WriteLine("\tInput Time now in 24 hours(Input 25 to Back): ");
					DrawStarLine();                    
                	time = double.TryParse(Console.ReadLine(), out timeselector);
					Console.Clear();
				if  (timeselector >= 7 & timeselector <= 9){
					DrawStarLine();
					Console.WriteLine("Period Time: 7:00 - 9:00\nSubject: ITEP 202\nSection&Year: BSIT 2-A\nInstructor: Mr. Gustilo ll");
					DrawStarLine();
					Console.WriteLine("\nEnter to Back...");
                }
				else if (timeselector >= 10 & timeselector <= 12){
					DrawStarLine();
					Console.WriteLine("Period Time: 10:00 - 12:00\nSubject: ITEP 102 Foundation of  Programming\nSection&Year: BSIT 1-B\nInstructor: Mr. De jesus");
					DrawStarLine();
					Console.WriteLine("\nEnter to Back...");
                }
				else if (timeselector > 12 & timeselector <= 15){
					DrawStarLine();
					Console.WriteLine("Period Time: 12:00 - 3:00\nSubject: Analytics Application\nSection&Year: BSIT 4-A\nInstructor: F. URERA");
					DrawStarLine();
					Console.WriteLine("\nEnter to Back...");
                }
				else if (timeselector > 15 & timeselector <= 17){
					DrawStarLine();
				Console.WriteLine("Period Time: 3:00 - 5:00\nSubject: ITEC 102\nSection&Year: BSIS 1-A\nInstructor: Ms. Mortel");
					DrawStarLine();
					Console.WriteLine("\nEnter to Back...");
					}
				else if(timeselector != MonmaxMenuItems){
					Console.WriteLine("NO SCHEDULE ASSIGN/Typing error (Press any key...)");
                            }
                else{
                    Console.WriteLine("Press any key...");
                }
                Console.ReadKey();
            }                    	       	
            }
            private static void TueRoom204(){
            const double MonmaxMenuItems = 25;
            double timeselector = 0;
            bool time = false;
            while (timeselector != MonmaxMenuItems){
                Console.Clear();
                DrawStarLine();
                    	Console.ForegroundColor = ConsoleColor.Green; Console.WriteLine("\t\t\t***TUESDAY***"); Console.ResetColor();
                    	Console.WriteLine("\tInput Time now in 24 hours(Input 25 to Back): ");  DrawStarLine();
                time = double.TryParse(Console.ReadLine(), out timeselector);
                Console.Clear();
				if (timeselector >= 7 && timeselector <= 9){DrawStarLine();
					Console.WriteLine("Period Time: 7:00 - 9:00\nSubject: ITEP 202 Data Structure\nSection&Year: BSIT 2-A\nInstructor: Mr. Gustilo ll");
					DrawStarLine();
					Console.WriteLine("\nEnter to Back...");
                }
				else if (timeselector > 10 && timeselector <= 12){DrawStarLine();
					Console.WriteLine("Period Time: 10:00 - 12:00\nSubject: ITEC 102 Fundamentals of Programming\nSection&Year: BSIT 1-C\nInstructor: Mr. Pacaon");
					DrawStarLine();
					Console.WriteLine("\nEnter to Back...");
                }
				else if (timeselector >= 13 && timeselector <= 14){DrawStarLine();
					Console.WriteLine("Period Time: 1:00 - 2:00\nSubject: BAANAD Analytics Application\nSection&Year: BSIT 4-A\nInstructor: F. URERA");
					DrawStarLine();
					Console.WriteLine("\nEnter to Back...");
                }
				else if (timeselector >= 15 & timeselector <= 17){
					DrawStarLine();
				Console.WriteLine("Period Time: 3:00 - 5:00\nSubject: ITEC 102 Fundamentals of Programming\nSection&Year: BSCS 1-A\nInstructor: Mr. Pacaon");
					DrawStarLine();
					Console.WriteLine("\nEnter to Back...");
					}
				else if (timeselector != MonmaxMenuItems){
					Console.WriteLine("NO SCHEDULE ASSIGN/Typing error (Press any key...)");
                            }
                else{
                    Console.WriteLine("Press any key...");
                }
                Console.ReadKey();
            }                    	        	
            }
            private static void WedRoom204(){
            const double MonmaxMenuItems = 25;
            double timeselector = 0;
            bool time = false;
            while (timeselector != MonmaxMenuItems){
                Console.Clear();
                	DrawStarLine();
                    Console.ForegroundColor = ConsoleColor.Green; Console.WriteLine("\t\t\t***WEDNESDAY***"); Console.ResetColor();
                    Console.WriteLine("\tInput Time now in 24 hours(Input 25 to Back): ");
					DrawStarLine();                    
                	time = double.TryParse(Console.ReadLine(), out timeselector);
					Console.Clear();
				if  (timeselector >= 10 & timeselector <= 12){
					DrawStarLine();
					Console.WriteLine("Period Time: 10:00 - 12:00\nSubject: Fundamentals of Programming\nSection&Year: BSIT 1-B\nInstructor: Mr. De jesus");
					DrawStarLine();
					Console.WriteLine("\nEnter to Back...");
                }
				else if (timeselector > 13 & timeselector <= 15){
					DrawStarLine();
					Console.WriteLine("Period Time: 1:00 - 3:00\nSubject: ITEC 102 Fundamentals of Programming\nSection&Year: BSIT 1-C\nInstructor: Mr. Pacaon");
					DrawStarLine();
					Console.WriteLine("\nEnter to Back...");
                }
				else if(timeselector != MonmaxMenuItems){
					Console.WriteLine("NO SCHEDULE ASSIGN/Typing error (Press any key...)");
                            }
                else{
                    Console.WriteLine("Press any key...");
                }
                Console.ReadKey();
            }                    	         	
            }
            private static void ThuRoom204(){
            const double MonmaxMenuItems = 25;
            double timeselector = 0;
            bool time = false;
            while (timeselector != MonmaxMenuItems){
                Console.Clear();
                	DrawStarLine();
                    Console.ForegroundColor = ConsoleColor.Green; Console.WriteLine("\t\t\t***THURSDAY***"); Console.ResetColor();
                    Console.WriteLine("\tInput Time now in 24 hours(Input 25 to Back): ");
					DrawStarLine();                    
                	time = double.TryParse(Console.ReadLine(), out timeselector);
					Console.Clear();
				if  (timeselector >= 7 & timeselector <= 10.5){
					DrawStarLine();
					Console.WriteLine("Period Time: 7:00 - 10:30\nSubject: ITEP 310 System Analytics and Design\nSection&Year: BSIT 3-B\nInstructor: A. De Luna");
					DrawStarLine();
					Console.WriteLine("\nEnter to Back...");
                }
				else if (timeselector > 10 & timeselector <= 14){
					DrawStarLine();
					Console.WriteLine("Period Time: 10:30 - 2:00\nSubject: ITEC 102 Fundamentals of Programming\nSection&Year: BSIT 1-D\nInstructor: Mr. Pacaon");
					DrawStarLine();
					Console.WriteLine("\nEnter to Back...");
                }
				else if (timeselector > 14 & timeselector <= 17){
					DrawStarLine();
					Console.WriteLine("Period Time: 2:00 - 5:00\nSubject: ITEC 102 Fundamentals of Programming\nSection&Year: BSCS 1-A\nInstructor: Mr. Pacaon");
					DrawStarLine();
					Console.WriteLine("\nEnter to Back...");
                }
				else if(timeselector != MonmaxMenuItems){
					Console.WriteLine("NO SCHEDULE ASSIGN/Typing error (Press any key...)");
                            }
                else{
                    Console.WriteLine("Press any key...");
                }
                Console.ReadKey();
            }                    	      	
            }
            private static void FriRoom204()
            {
            const double MonmaxMenuItems = 25;
            double timeselector = 0;
            bool time = false;
            while (timeselector != MonmaxMenuItems){
                Console.Clear();
                	DrawStarLine();
                    Console.ForegroundColor = ConsoleColor.Green; Console.WriteLine("\t\t\t***FRIDAY***"); Console.ResetColor();
                    Console.WriteLine("\tInput Time now in 24 hours(Input 25 to Back): ");
					DrawStarLine();                    
                	time = double.TryParse(Console.ReadLine(), out timeselector);
					Console.Clear();
				if  (timeselector >= 7 & timeselector <= 10){
					DrawStarLine();
					Console.WriteLine("Period Time: 7:00 - 10:00\nSubject: KEYBOARDING\nSection&Year: BSOA 1-B\nInstructor: ");
					DrawStarLine();
					Console.WriteLine("\nEnter to Back...");
                }
				else if (timeselector > 10 & timeselector <= 12.5){
					DrawStarLine();
					Console.WriteLine("Period Time: 10:00 - 12:30\nSubject: ITEC 206 Computer Organization\nSection&Year: BSIT 1-A\nInstructor: Mr. R. Diaz");
					DrawStarLine();
					Console.WriteLine("\nEnter to Back...");
                }
				else if (timeselector > 14.5 & timeselector <= 17){
					DrawStarLine();
				Console.WriteLine("Period Time: 2:30 - 5:00\nSubject: ITEC 102\nSection&Year: BSIT 1-B\nInstructor: Mr. Pacaon");
					DrawStarLine();
					Console.WriteLine("\nEnter to Back...");
					}
				else if(timeselector != MonmaxMenuItems){
					Console.WriteLine("NO SCHEDULE ASSIGN/Typing error (Press any key...)");
                            }
                else{
                    Console.WriteLine("Press any key...");
                }
                Console.ReadKey();
            }                    	
                    	
            }
            private static void AWRoom204(){
            Console.Clear();
            DrawStarLine();
            Console.ForegroundColor = ConsoleColor.Green; Console.WriteLine("\t\t**********CCS VOAG ROOM 204 ALL WEEK SCHEDULE**********\n"); Console.ResetColor();
			Console.WriteLine("\tMONDAY\nPeriod Time: 7:00 - 9:00\nSubject: ITEP 202\nSection&Year: BSIT 2-A\nInstructor: Mr. Gustilo ll\nPeriod Time: 10:00 - 12:00\nSubject: ITEP 102 Foundation of  Programming\nSection&Year: BSIT 1-B\nInstructor: Mr. De jesus\nPeriod Time: 12:00 - 3:00\nSubject: Analytics Application\nSection&Year: BSIT 4-A\nInstructor: F. URERA\nPeriod Time: 3:00 - 5:00\nSubject: ITEC 102\nSection&Year: BSIS 1-A\nInstructor: Ms. Mortel");
			DrawStarLine();
			Console.WriteLine("\tTUESDAY\nPeriod Time: 7:00 - 9:00\nSubject: ITEP 202 Data Structure\nSection&Year: BSIT 2-A\nInstructor: Mr. Gustilo ll\nPeriod Time: 10:00 - 12:00\nSubject: ITEC 102 Fundamentals of Programming\nSection&Year: BSIT 1-C\nInstructor: Mr. Pacaon\nPeriod Time: 1:00 - 2:00\nSubject: BAANAD Analytics Application\nSection&Year: BSIT 4-A\nInstructor: F. URERA\nPeriod Time: 3:00 - 5:00\nSubject: ITEC 102 Fundamentals of Programming\nSection&Year: BSCS 1-A\nInstructor: Mr. Pacaon");
			DrawStarLine();
			Console.WriteLine("\tWEDNESDAY\nPeriod Time: 10:00 - 12:00\nSubject: Fundamentals of Programming\nSection&Year: BSIT 1-B\nInstructor: Mr. De jesus\nPeriod Time: 1:00 - 3:00\nSubject: ITEC 102 Fundamentals of Programming\nSection&Year: BSIT 1-C\nInstructor: Mr. Pacaon");
			DrawStarLine();
			Console.WriteLine("\tTHURSDAY\nPeriod Time: 7:00 - 10:30\nSubject: ITEP 310 System Analytics and Design\nSection&Year: BSIT 3-B\nInstructor: A. De Luna\nPeriod Time: 10:30 - 2:00\nSubject: ITEC 102 Fundamentals of Programming\nSection&Year: BSIT 1-D\nInstructor: Mr. Pacaon\nPeriod Time: 2:00 - 5:00\nSubject: ITEC 102 Fundamentals of Programming\nSection&Year: BSCS 1-A\nInstructor: Mr. Pacaon");
			DrawStarLine();
			Console.WriteLine("\tFRIDAY\nPeriod Time: 7:00 - 10:00\nSubject: KEYBOARDING\nSection&Year: BSOA 1-B\nInstructor: \nPeriod Time: 10:00 - 12:30\nSubject: ITEC 206 Computer Organization\nSection&Year: BSIT 1-A\nInstructor: Mr. R. Diaz\nPeriod Time: 2:30 - 5:00\nSubject: ITEC 102\nSection&Year: BSIT 1-B\nInstructor: Mr. Pacaon");
            DrawStarLine();
            Console.WriteLine("\nPress any key..");
            }
        //ROOM 205 INFO.
        private static void DisplayRoom205(){
            const int maxMenuItems = 7;
            int selector = 0;
            bool good = false;
            while (selector != maxMenuItems){
                Console.Clear();
                DrawStarLine();
                    Console.ForegroundColor = ConsoleColor.Green; Console.WriteLine("\t\t***CCS VOAG ROOM 205 SCHEDULE***"); Console.ResetColor();
                DrawStarLine();
                DrawMenu205(maxMenuItems);
                //user input
                good = int.TryParse(Console.ReadLine(), out selector);
                if (good){
					switch (selector){
                        case 1:
							MonRoom205();
							break;
                        case 2:
                            TueRoom205();
                            break;
                        case 3:
                            WedRoom205();
                            break;
                        case 4:
                            ThuRoom205();
                            break;
                        case 5:
                            FriRoom205();
                            break;
                        case 6:
                            AWRoom205();
                            break;                            
                        default:
                            if (selector != maxMenuItems)
                            { ErrorMessage();
                         } break;
                    }
                }
                else
                { ErrorMessage();
                } Console.ReadKey();
            }
            }
            private static void DrawMenu205(int maxitems){ 
            Console.WriteLine("[1] = Monday\n[2] = Tuesday\n[3] = Wednesday\n[4] = Thursday\n[5] = Friday\n[6] = All Week Schedule");
            DrawStarLine();
            Console.ForegroundColor = ConsoleColor.DarkGray; Console.WriteLine("  Make your choice: type 1, 2,... or {0} Go Back to Room Choices", maxitems); Console.ResetColor();
            DrawStarLine();
            }
            private static void MonRoom205(){
            const double MonmaxMenuItems = 25;
            double timeselector = 0;
            bool time = false;
            while (timeselector != MonmaxMenuItems){
                Console.Clear();
                	DrawStarLine();
                    Console.ForegroundColor = ConsoleColor.Green; Console.WriteLine("\t\t\t***MONDAY***"); Console.ResetColor();
                    Console.WriteLine("\tInput Time now in 24 hours(Input 25 to Back): ");
					DrawStarLine();                    
                	time = double.TryParse(Console.ReadLine(), out timeselector);
					Console.Clear();
				if  (timeselector >= 7.5 & timeselector <= 9.5){
					DrawStarLine();
					Console.WriteLine("");
					DrawStarLine();
					Console.WriteLine("\nEnter to Back...");
                }
				else if (timeselector > 9.5 & timeselector <= 12){
					DrawStarLine();
					Console.WriteLine("");
					DrawStarLine();
					Console.WriteLine("\nEnter to Back...");
                }
				else if (timeselector >= 13 & timeselector <= 16){
					DrawStarLine();
					Console.WriteLine("");
					DrawStarLine();
					Console.WriteLine("\nEnter to Back...");
                }
				else if(timeselector != MonmaxMenuItems){
					Console.WriteLine("NO SCHEDULE ASSIGN/Typing error (Press any key...)");
                            }
                else{
                    Console.WriteLine("Press any key...");
                }
                Console.ReadKey();
            }                    	       	
            }
            private static void TueRoom205(){
            const double MonmaxMenuItems = 25;
            double timeselector = 0;
            bool time = false;
            while (timeselector != MonmaxMenuItems){
                Console.Clear();
                DrawStarLine();
                    	Console.ForegroundColor = ConsoleColor.Green; Console.WriteLine("\t\t\t***TUESDAY***"); Console.ResetColor();
                    	Console.WriteLine("\tInput Time now in 24 hours(Input 25 to Back): "); DrawStarLine(); 
                time = double.TryParse(Console.ReadLine(), out timeselector);
				if (timeselector >= 8 && timeselector <= 10){
					Console.WriteLine("");
					DrawStarLine();
					Console.WriteLine("\nEnter to Back...");
                }
				else if (timeselector > 10 && timeselector <= 12){
					Console.WriteLine("");
					DrawStarLine();
					Console.WriteLine("\nEnter to Back...");
                }
				else if (timeselector >= 13 && timeselector <= 14){
					Console.WriteLine("");
					DrawStarLine();
					Console.WriteLine("\nEnter to Back...");
                }
				else if (timeselector != MonmaxMenuItems){
					Console.WriteLine("NO SCHEDULE ASSIGN/Typing error (Press any key...)");
                            }
                else{
                    Console.WriteLine("Press any key...");
                }
                Console.ReadKey();
            }                    	        	
            }
            private static void WedRoom205(){
            const double MonmaxMenuItems = 25;
            double timeselector = 0;
            bool time = false;
            while (timeselector != MonmaxMenuItems){
                Console.Clear();
                	DrawStarLine();
                    Console.ForegroundColor = ConsoleColor.Green; Console.WriteLine("\t\t\t***WEDNESDAY***"); Console.ResetColor();
                    Console.WriteLine("\tInput Time now in 24 hours(Input 25 to Back): ");
					DrawStarLine();                    
                	time = double.TryParse(Console.ReadLine(), out timeselector);
					Console.Clear();
				if  (timeselector >= 7.5 & timeselector <= 10.5){
					DrawStarLine();
					Console.WriteLine("");
					DrawStarLine();
					Console.WriteLine("\nEnter to Back...");
                }
				else if (timeselector > 10.5 & timeselector <= 11.5){
					DrawStarLine();
					Console.WriteLine("");
					DrawStarLine();
					Console.WriteLine("\nEnter to Back...");
                }
				else if (timeselector >= 12 & timeselector <= 13){
					DrawStarLine();
					Console.WriteLine("");
					DrawStarLine();
					Console.WriteLine("\nEnter to Back...");
                }
				else if (timeselector >= 14.5 & timeselector <= 15){
					DrawStarLine();
					Console.WriteLine("");
					DrawStarLine();
					Console.WriteLine("\nEnter to Back...");
                }
				else if(timeselector != MonmaxMenuItems){
					Console.WriteLine("NO SCHEDULE ASSIGN/Typing error (Press any key...)");
                            }
                else{
                    Console.WriteLine("Press any key...");
                }
                Console.ReadKey();
            }                    	         	
            }
            private static void ThuRoom205(){
            const double MonmaxMenuItems = 25;
            double timeselector = 0;
            bool time = false;
            while (timeselector != MonmaxMenuItems){
                Console.Clear();
                	DrawStarLine();
                    Console.ForegroundColor = ConsoleColor.Green; Console.WriteLine("\t\t\t***THURSDAY***"); Console.ResetColor();
                    Console.WriteLine("\tInput Time now in 24 hours(Input 25 to Back): ");
					DrawStarLine();                    
                	time = double.TryParse(Console.ReadLine(), out timeselector);
					Console.Clear();
				if  (timeselector >= 8 & timeselector <= 9.5){
					DrawStarLine();
					Console.WriteLine("");
					DrawStarLine();
					Console.WriteLine("\nEnter to Back...");
                }
				else if (timeselector >= 10 & timeselector <= 13){
					DrawStarLine();
					Console.WriteLine("");
					DrawStarLine();
					Console.WriteLine("\nEnter to Back...");
                }
				else if (timeselector >= 13.5 & timeselector <= 14){
					DrawStarLine();
					Console.WriteLine("");
					DrawStarLine();
					Console.WriteLine("\nEnter to Back...");
                }
				else if (timeselector > 14 & timeselector <= 16){
					DrawStarLine();
					Console.WriteLine("");
					DrawStarLine();
					Console.WriteLine("\nEnter to Back...");
                }
				else if(timeselector != MonmaxMenuItems){
					Console.WriteLine("NO SCHEDULE ASSIGN/Typing error (Press any key...)");
                            }
                else{
                    Console.WriteLine("Press any key...");
                }
                Console.ReadKey();
            }                    	      	
            }
            private static void FriRoom205()
            {
            const double MonmaxMenuItems = 25;
            double timeselector = 0;
            bool time = false;
            while (timeselector != MonmaxMenuItems){
                Console.Clear();
                	DrawStarLine();
                    Console.ForegroundColor = ConsoleColor.Green; Console.WriteLine("\t\t\t***FRIDAY***"); Console.ResetColor();
                    Console.WriteLine("\tInput Time now in 24 hours(Input 25 to Back): ");
					DrawStarLine();                    
                	time = double.TryParse(Console.ReadLine(), out timeselector);
					Console.Clear();
				if  (timeselector >= 10 & timeselector <= 11.5){
					DrawStarLine();
					Console.WriteLine("");
					DrawStarLine();
					Console.WriteLine("\nEnter to Back...");
                }
				else if (timeselector >= 15 & timeselector <= 16){
					DrawStarLine();
					Console.WriteLine("");
					DrawStarLine();
					Console.WriteLine("\nEnter to Back...");
                }
				else if(timeselector != MonmaxMenuItems){
					Console.WriteLine("NO SCHEDULE ASSIGN/Typing error (Press any key...)");
                            }
                else{
                    Console.WriteLine("Press any key...");
                }
                Console.ReadKey();
            }                    	
                    	
            }
            private static void AWRoom205(){
            Console.Clear();
            DrawStarLine();
            Console.ForegroundColor = ConsoleColor.Green; Console.WriteLine("\t\t**********CCS VOAG ROOM 205 ALL WEEK SCHEDULE**********\n"); Console.ResetColor();
			Console.WriteLine("\tMONDAY\n");
			DrawStarLine();
			Console.WriteLine("\tTUESDAY\n");
			DrawStarLine();
			Console.WriteLine("\tWEDNESDAY\n");
			DrawStarLine();
			Console.WriteLine("\tTHURSDAY\n");
			DrawStarLine();
			Console.WriteLine("\tFRIDAY\n");
            DrawStarLine();
            Console.WriteLine("\nPress any key..");
            }
        //ROOM 206 INFO.
        private static void DisplayRoom206(){
            const int maxMenuItems = 7;
            int selector = 0;
            bool good = false;
            while (selector != maxMenuItems){
                Console.Clear();
                DrawStarLine();
                    Console.ForegroundColor = ConsoleColor.Green; Console.WriteLine("\t\t***CCS VOAG ROOM 206 SCHEDULE***"); Console.ResetColor();
                DrawStarLine();
                DrawMenu206(maxMenuItems);
                //user input
                good = int.TryParse(Console.ReadLine(), out selector);
                if (good){
					switch (selector){
                        case 1:
							MonRoom206();
							break;
                        case 2:
                            TueRoom206();
                            break;
                        case 3:
                            WedRoom206();
                            break;
                        case 4:
                            ThuRoom206();
                            break;
                        case 5:
                            FriRoom206();
                            break;
                        case 6:
                            AWRoom206();
                            break;                            
                        default:
                            if (selector != maxMenuItems)
                            { ErrorMessage();
                         } break;
                    }
                }
                else
                { ErrorMessage();
                } Console.ReadKey();
            }
            }
            private static void DrawMenu206(int maxitems){ 
            Console.WriteLine("[1] = Monday\n[2] = Tuesday\n[3] = Wednesday\n[4] = Thursday\n[5] = Friday\n[6] = All Week Schedule");
            DrawStarLine();
            Console.ForegroundColor = ConsoleColor.DarkGray; Console.WriteLine("  Make your choice: type 1, 2,... or {0} Go Back to Room Choices", maxitems); Console.ResetColor();
            DrawStarLine();
            }
            private static void MonRoom206(){
            const double MonmaxMenuItems = 25;
            double timeselector = 0;
            bool time = false;
            while (timeselector != MonmaxMenuItems){
                Console.Clear();
                	DrawStarLine();
                    Console.ForegroundColor = ConsoleColor.Green; Console.WriteLine("\t\t\t***MONDAY***"); Console.ResetColor();
                    Console.WriteLine("\tInput Time now in 24 hours(Input 25 to Back): ");
					DrawStarLine();                    
                	time = double.TryParse(Console.ReadLine(), out timeselector);
					Console.Clear();
				if  (timeselector >= 7.5 & timeselector <= 9.5){
					DrawStarLine();
					Console.WriteLine("Period Time: 7:30 - 9:30\nSubject: HCI Human Computer Interaction\nSection&Year: BSIS IV-A\nInstructor: Mr. F. Urera Jr.");
					DrawStarLine();
					Console.WriteLine("\nEnter to Back...");
                }
				else if (timeselector > 9.5 & timeselector <= 12){
					DrawStarLine();
					Console.WriteLine("Period Time: 9:30 - 12:00\nSubject: CT 211\nSection&Year: ACT 2-A\nInstructor: A.Dela Torre");
					DrawStarLine();
					Console.WriteLine("\nEnter to Back...");
                }
				else if (timeselector >= 13 & timeselector <= 16){
					DrawStarLine();
					Console.WriteLine("Period Time: 1:00 - 4:00\nSubject: CT 123 Data Structure\nSection&Year: ACT I-C\nInstructor: Mr. Gustillo II");
					DrawStarLine();
					Console.WriteLine("\nEnter to Back...");
                }
				else if(timeselector != MonmaxMenuItems){
					Console.WriteLine("NO SCHEDULE ASSIGN/Typing error (Press any key...)");
                            }
                else{
                    Console.WriteLine("Press any key...");
                }
                Console.ReadKey();
            }                    	       	
            }
            private static void TueRoom206(){
            const double MonmaxMenuItems = 25;
            double timeselector = 0;
            bool time = false;
            while (timeselector != MonmaxMenuItems){
                Console.Clear();
                DrawStarLine();
                    	Console.ForegroundColor = ConsoleColor.Green; Console.WriteLine("\t\t\t***TUESDAY***"); Console.ResetColor();
                    	Console.WriteLine("\tInput Time now in 24 hours(Input 25 to Back): "); DrawStarLine();
                time = double.TryParse(Console.ReadLine(), out timeselector);
                Console.Clear();
				if (timeselector >= 8 && timeselector <= 9){DrawStarLine();
					Console.WriteLine("Period Time: 8:00 -9:00\nSubject: HCI\nSection&Year: BSIT IV-A\nInstructor: Mr. F. Urera Jr.");
					DrawStarLine();
					Console.WriteLine("\nEnter to Back...");
                }
				else if (timeselector > 9 && timeselector <= 12){DrawStarLine();
					Console.WriteLine("Period Time: 9:00 - 12:00\nSubject: ITEC 102 Fundamentals of Programming\nSection&Year: BSIT I-A\nInstructor: Ms. Mortel");
					DrawStarLine();
					Console.WriteLine("\nEnter to Back...");
                }
				else if (timeselector >= 13 && timeselector <= 15){DrawStarLine();
					Console.WriteLine("Period Time: 1:00 - 3:00\nSubject: ITEC 301 Object Oriented Programming\nSection&Year: BSIT 3-A\nInstructor: A. Dela Torre");
					DrawStarLine();
					Console.WriteLine("\nEnter to Back...");
                }
				else if (timeselector > 15 & timeselector <= 17){
					DrawStarLine();
				Console.WriteLine("Period Time: 3:00 - 5:00\nSubject: FTS Field Trips & Seminars\nSection&Year: BSIS 3-AnInstructor: Ms. Mortel");
					DrawStarLine();
					Console.WriteLine("\nEnter to Back...");
					}
				else if (timeselector != MonmaxMenuItems){
					Console.WriteLine("NO SCHEDULE ASSIGN/Typing error (Press any key...)");
                            }
                else{
                    Console.WriteLine("Press any key...");
                }
                Console.ReadKey();
            }                    	        	
            }
            private static void WedRoom206(){
            const double MonmaxMenuItems = 25;
            double timeselector = 0;
            bool time = false;
            while (timeselector != MonmaxMenuItems){
                Console.Clear();
                	DrawStarLine();
                    Console.ForegroundColor = ConsoleColor.Green; Console.WriteLine("\t\t\t***WEDNESDAY***"); Console.ResetColor();
                    Console.WriteLine("\tInput Time now in 24 hours(Input 25 to Back): ");
					DrawStarLine();                    
                	time = double.TryParse(Console.ReadLine(), out timeselector);
					Console.Clear();
				if  (timeselector >= 7 & timeselector <= 9.5){
					DrawStarLine();
					Console.WriteLine("Period Time: 7:00 - 9:30\nSubject: ITEC 102 Fundamentals of Programming\nSection&Year: BSIS I-A\nInstructor: Mr. Mortel");
					DrawStarLine();
					Console.WriteLine("\nEnter to Back...");
                }
				else if (timeselector > 9.5 & timeselector <= 12.5){
					DrawStarLine();
					Console.WriteLine("Period Time: 9:30 - 12:30\nSubject: CTI21 Computer Programming 2\nSection&Year: ACT I-A\nInstructor: Ms. Mortel");
					DrawStarLine();
					Console.WriteLine("\nEnter to Back...");
                }
				else if (timeselector >= 13 & timeselector <= 14){
					DrawStarLine();
					Console.WriteLine("Period Time: 1:00 - 2:00\nSubject: ITEC 101\nSection&Year: BSIT I-D\nInstructor: Ms. Mortel");
					DrawStarLine();
					Console.WriteLine("\nEnter to Back...");
                }
				else if (timeselector >= 14 & timeselector <= 17){
					DrawStarLine();
					Console.WriteLine("Period Time: 2:00 - 5:00\nSubject: CT 121 Computer Programming 2\nSection&Year: ACT I-C\nInstructor: Mr. Urera");
					DrawStarLine();
					Console.WriteLine("\nEnter to Back...");
                }
				else if(timeselector != MonmaxMenuItems){
					Console.WriteLine("NO SCHEDULE ASSIGN/Typing error (Press any key...)");
                            }
                else{
                    Console.WriteLine("Press any key...");
                }
                Console.ReadKey();
            }                    	         	
            }
            private static void ThuRoom206(){
            const double MonmaxMenuItems = 25;
            double timeselector = 0;
            bool time = false;
            while (timeselector != MonmaxMenuItems){
                Console.Clear();
                	DrawStarLine();
                    Console.ForegroundColor = ConsoleColor.Green; Console.WriteLine("\t\t\t***THURSDAY***"); Console.ResetColor();
                    Console.WriteLine("\tInput Time now in 24 hours(Input 25 to Back): ");
					DrawStarLine();                    
                	time = double.TryParse(Console.ReadLine(), out timeselector);
					Console.Clear();
				if  (timeselector >= 8.5 & timeselector <= 10){
					DrawStarLine();
					Console.WriteLine("Period Time: 8:30 - 10:00\nSubject: ITEC 101 Introduction to Information Technology Computing\nSection&Year: BSIT I-A\nInstructor: Mr. Pacaon");
					DrawStarLine();
					Console.WriteLine("\nEnter to Back...");
                }
				else if (timeselector > 10 & timeselector <= 12){
					DrawStarLine();
					Console.WriteLine("Period Time: 10:00 - 12:00\nSubject: ITEC 102 Fundementals of Programming\nSection&Year: BSIT I-A\nInstructor: Ms. Mortel");
					DrawStarLine();
					Console.WriteLine("\nEnter to Back...");
                }
				else if (timeselector >= 14.5 & timeselector <= 17){
					DrawStarLine();
					Console.WriteLine("Period Time: 2:30 - 5:00\nSubject: ICT\nSection&Year: BSAdEd 2-A\nInstructor: Mr. De jesus");
					DrawStarLine();
					Console.WriteLine("\nEnter to Back...");
                }
				else if(timeselector != MonmaxMenuItems){
					Console.WriteLine("NO SCHEDULE ASSIGN/Typing error (Press any key...)");
                            }
                else{
                    Console.WriteLine("Press any key...");
                }
                Console.ReadKey();
            }                    	      	
            }
            private static void FriRoom206()
            {
            const double MonmaxMenuItems = 25;
            double timeselector = 0;
            bool time = false;
            while (timeselector != MonmaxMenuItems){
                Console.Clear();
                	DrawStarLine();
                    Console.ForegroundColor = ConsoleColor.Green; Console.WriteLine("\t\t\t***FRIDAY***"); Console.ResetColor();
                    Console.WriteLine("\tInput Time now in 24 hours(Input 25 to Back): ");
					DrawStarLine();                    
                	time = double.TryParse(Console.ReadLine(), out timeselector);
					Console.Clear();
				if  (timeselector >= 7 & timeselector <= 12){
					DrawStarLine();
					Console.WriteLine("Period Time:7:00 - 12:00\nSubject: BBC 109\nSection&Year: BSBA IV - FM - A\nInstructor: Mr. Santelices");
					DrawStarLine();
					Console.WriteLine("\nEnter to Back...");
                }
				else if (timeselector >= 13 & timeselector <= 14.5){
					DrawStarLine();
					Console.WriteLine("Period Time: 1:00 - 2:30\nSubject: ITEC 102 Fundamentals of Programming\nSection&Year: BSIT I-D\nInstructor: Mr. Pacaon");
					DrawStarLine();
					Console.WriteLine("\nEnter to Back...");
                }
				else if (timeselector > 14.5 & timeselector <= 17){
					DrawStarLine();
				Console.WriteLine("Period Time: 2:30 - 5:00\nSubject: ICT\nSection&Year: BSAgEd 2-774\nInstructor: Mr. De jesus");
					DrawStarLine();
					Console.WriteLine("\nEnter to Back...");
					}
				else if(timeselector != MonmaxMenuItems){
					Console.WriteLine("NO SCHEDULE ASSIGN/Typing error (Press any key...)");
                            }
                else{
                    Console.WriteLine("Press any key...");
                }
                Console.ReadKey();
            }                    	
                    	
            }
            private static void AWRoom206(){
            Console.Clear();
            DrawStarLine();
            Console.ForegroundColor = ConsoleColor.Green; Console.WriteLine("\t\t**********CCS VOAG ROOM 206 ALL WEEK SCHEDULE**********\n"); Console.ResetColor();
			Console.WriteLine("\tMONDAY\nPeriod Time: 7:30 - 9:30\nSubject: HCI Human Computer Interaction\nSection&Year: BSIS IV-A\nInstructor: Mr. F. Urera Jr.\nPeriod Time: 9:30 - 12:00\nSubject: CT 211\nSection&Year: ACT 2-A\nInstructor: A.Dela Torre\nPeriod Time: 1:00 - 4:00\nSubject: CT 123 Data Structure\nSection&Year: ACT I-C\nInstructor: Mr. Gustillo II");
			DrawStarLine();
			Console.WriteLine("\tTUESDAY\nPeriod Time: 8:00 -9:00\nSubject: HCI\nSection&Year: BSIT IV-A\nInstructor: Mr. F. Urera Jr.\nPeriod Time: 9:00 - 12:00\nSubject: ITEC 102 Fundamentals of Programming\nSection&Year: BSIT I-A\nInstructor: Ms. Mortel\nPeriod Time: 1:00 - 3:00\nSubject: ITEC 301 Object Oriented Programming\nSection&Year: BSIT 3-A\nInstructor: A. Dela Torre\nPeriod Time: 3:00 - 5:00\nSubject: FTS Field Trips & Seminars\nSection&Year: BSIS 3-AnInstructor: Ms. Mortel");
			DrawStarLine();
			Console.WriteLine("\tWEDNESDAY\nPeriod Time: 7:00 - 9:30\nSubject: ITEC 102 Fundamentals of Programming\nSection&Year: BSIS I-A\nInstructor: Mr. Mortel\nPeriod Time: 9:30 - 12:30\nSubject: CTI21 Computer Programming 2\nSection&Year: ACT I-A\nInstructor: Ms. Mortel\nPeriod Time: 1:00 - 2:00\nSubject: ITEC 101\nSection&Year: BSIT I-D\nInstructor: Ms. Mortel\nPeriod Time: 2:00 - 5:00\nSubject: CT 121 Computer Programming 2\nSection&Year: ACT I-C\nInstructor: Mr. Urera");
			DrawStarLine();
			Console.WriteLine("\tTHURSDAY\nPeriod Time: 8:30 - 10:00\nSubject: ITEC 101 Introduction to Information Technology Computing\nSection&Year: BSIT I-A\nInstructor: Mr. Pacaon\nPeriod Time: 10:00 - 12:00\nSubject: ITEC 102 Fundementals of Programming\nSection&Year: BSIT I-A\nInstructor: Ms. Mortel\nPeriod Time: 2:30 - 5:00\nSubject: ICT\nSection&Year: BSAdEd 2-A\nInstructor: Mr. De jesus");
			DrawStarLine();
			Console.WriteLine("\tFRIDAY\nPeriod Time:7:00 - 12:00\nSubject: BBC 109\nSection&Year: BSBA IV - FM - A\nInstructor: Mr. Santelices\nPeriod Time: 1:00 - 2:30\nSubject: ITEC 102 Fundamentals of Programming\nSection&Year: BSIT I-D\nInstructor: Mr. Pacaon\nPeriod Time: 2:30 - 5:00\nSubject: ICT\nSection&Year: BSAgEd 2-774\nInstructor: Mr. De jesus");
            DrawStarLine();
            Console.WriteLine("\nPress any key..");
            }
        }
    }