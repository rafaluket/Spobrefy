using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;
using System.Threading;
using System.Timers;
using System.IO;

namespace Spobrefy_App
{
    /*Program developed by Luket
     This program it's a offline playlist Music, like a spotify but poor XDXD
     Finished.*/
    public class OpDuringMusic
    {
    }
    class Program
    {
        public int opMusic = 0;
        public int exitMusic = 1;
        public int exitGenre = 1;

        static void Main(string[] args)
        {
            var myPlayer = new System.Media.SoundPlayer();
            Program thisProgram = new Program();
            OpDuringMusic thisOpDuringMusic = new OpDuringMusic();


            Console.Title = "SpobrefY";
            Console.SetWindowSize(120, 27);
            Console.SetBufferSize(120, 27);
            Console.SetWindowPosition(0, 0);
            Console.CursorVisible = false;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n\n\n\t\t\t\t.───────.            __               ____.──. .──.\n\t\t\t\t│       │─────.─────│  │──.────.─────│  __|  │ │  │\n\t\t\t\t│   │___|  o  │  o  │  o  │   _│  °__|  __|  ┴-┴  │\n\t\t\t\t| ____  │   __│_____│_____|__│ │_____│__│ │__   __│\n\t\t\t\t│:  │   │__|                                │:  │\n\t\t\t\t│::.. . │                                   │::.│\n\t\t\t\t`───────´                                   `───´");
            Console.ForegroundColor = ConsoleColor.White;
            WriteOnMiddle("╔═══════════════════════════╗");
            WriteOnMiddle("║         COMANDOS          ║");
            WriteOnMiddle("║ ───────────────────────── ║");
            WriteOnMiddle("║ |N| Next Music            ║");
            WriteOnMiddle("║ |P| Previous Music        ║");
            WriteOnMiddle("║ |E| Return to Musics List ║");
            WriteOnMiddle("╚═══════════════════════════╝");
            Console.ForegroundColor = ConsoleColor.Cyan;
            WriteOnMiddle("*PRESSIONE ENTER PARA COMEÇAR*");
            Console.ForegroundColor = ConsoleColor.Black;
            var opGenre = Console.ReadKey();
            Console.ForegroundColor = ConsoleColor.White;
            while (opGenre.Key != ConsoleKey.Enter)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\n\n\n\t\t\t\t.───────.            __               ____.──. .──.\n\t\t\t\t│       │─────.─────│  │──.────.─────│  __|  │ │  │\n\t\t\t\t│   │___|  o  │  o  │  o  │   _│  °__|  __|  ┴-┴  │\n\t\t\t\t| ____  │   __│_____│_____|__│ │_____│__│ │__   __│\n\t\t\t\t│:  │   │__|                                │:  │\n\t\t\t\t│::.. . │                                   │::.│\n\t\t\t\t`───────´                                   `───´");
                Console.ForegroundColor = ConsoleColor.White;
                WriteOnMiddle("╔═══════════════════════════╗");
                WriteOnMiddle("║         COMANDOS          ║");
                WriteOnMiddle("║ ───────────────────────── ║");
                WriteOnMiddle("║ |N| Next Music            ║");
                WriteOnMiddle("║ |P| Previous Music        ║");
                WriteOnMiddle("║ |E| Return to Musics List ║");
                WriteOnMiddle("╚═══════════════════════════╝");
                Console.ForegroundColor = ConsoleColor.Cyan;
                WriteOnMiddle("*PRESSIONE ENTER PARA COMEÇAR*");
                Console.ForegroundColor = ConsoleColor.Black;
                opGenre = Console.ReadKey();
                Console.ForegroundColor = ConsoleColor.White;

            }


            do
            {
                menuGenero();
                Console.ForegroundColor = ConsoleColor.Black;
                opGenre = Console.ReadKey();
                Console.ForegroundColor = ConsoleColor.White;
                while ((opGenre.Key < ConsoleKey.D0 || opGenre.Key > ConsoleKey.D3) && opGenre.Key < ConsoleKey.NumPad0 || opGenre.Key > ConsoleKey.NumPad3)
                {
                    menuGenero();
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    WriteOnMiddle("Errooou! :/");
                    WriteOnMiddle("Desculpe mas a opção de Playlist não existe.");
                    readOnMiddle("Tente novamente");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.ForegroundColor = ConsoleColor.Black;
                    opGenre = Console.ReadKey();
                    Console.ForegroundColor = ConsoleColor.White;
                }
                // Genre options START
                if (opGenre.Key == ConsoleKey.D1 || opGenre.Key == ConsoleKey.NumPad1)
                {
                    thisProgram.exitMusic = 1;
                    //Hip Hop Br options START
                    menuHipHopBr();
                    var opMusicVar = Console.ReadKey();
                    thisProgram.opMusic = int.Parse(opMusicVar.KeyChar.ToString());
                    while (thisProgram.opMusic < 0 || thisProgram.opMusic > 5)
                    {
                        menuHipHopBr();
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        WriteOnMiddle("Errooou! :/");
                        WriteOnMiddle("Desculpe mas a opção de música não existe.");
                        readOnMiddle("Tente novamente");
                        Console.ForegroundColor = ConsoleColor.White;
                        opMusicVar = Console.ReadKey();
                        thisProgram.opMusic = int.Parse(opMusicVar.KeyChar.ToString());
                    }
                    do
                    {
                        switch (thisProgram.opMusic)
                        {
                            case 1: //SIDOKA - PORSCHE
                                exibirListening();
                                Console.ForegroundColor = ConsoleColor.Red;
                                WriteOnMiddle("| PORSCHE |");
                                Console.ForegroundColor = ConsoleColor.DarkGray;
                                WriteOnMiddle("Sidoka");
                                Console.ResetColor();
                               
                                callMusic(@"C:\Playlist Music\Hip Hob Br\Sidoka - Porschew.wav");
                                musicOptions(thisOpDuringMusic, thisProgram);
                                break;
                            case 2: //DUDU, VK MAC - WTF(ASTRO)
                                exibirListening();
                                Console.ForegroundColor = ConsoleColor.Red;
                                WriteOnMiddle("| WTF(ASTRO) |");
                                Console.ForegroundColor = ConsoleColor.DarkGray;
                                WriteOnMiddle("Dudu, VK MAC");
                                Console.ResetColor();
                                callMusic(@"C:\Playlist Music\Hip Hob Br\Dudu, VK MAC - WTF(Astro).wav");
                                musicOptions(thisOpDuringMusic, thisProgram);
                                break;
                            case 3: //Buddy - MARCA UM 10
                                exibirListening();
                                Console.ForegroundColor = ConsoleColor.Red;
                                WriteOnMiddle("| MARCA UM 10 |");
                                Console.ForegroundColor = ConsoleColor.DarkGray;
                                WriteOnMiddle("Buddy, OIK");
                                Console.ResetColor();
                                callMusic(@"C:\Playlist Music\Hip Hob Br\Buddy - Marca Um 10 ft. OIK.wav");
                                musicOptions(thisOpDuringMusic, thisProgram);
                                break;
                            case 4: //Muzzike - JETFLIX
                                exibirListening();
                                Console.ForegroundColor = ConsoleColor.Red;
                                WriteOnMiddle("| JETFLIX |");
                                Console.ForegroundColor = ConsoleColor.DarkGray;
                                WriteOnMiddle("Muzzike,Deryck,Cabrera,Theo,Dnasty,Predella");
                                Console.ResetColor();
                                callMusic(@"C:\Playlist Music\Hip Hob Br\Muzzike,Deryck,Cabrera - JETFLIX feat. Theo Dnasty Predella.wav");
                                musicOptions(thisOpDuringMusic, thisProgram);  
                                break;
                            case 5: //MARGINAIS BOOMBAP - PREDELLA, FELP 22
                                exibirListening();
                                Console.ForegroundColor = ConsoleColor.Red;
                                WriteOnMiddle("| MARGINAIS BOOMBAP |");
                                Console.ForegroundColor = ConsoleColor.DarkGray;
                                WriteOnMiddle("Felp 22, Predella, Orochi, PK, NOG");
                                Console.ResetColor();
                                callMusic(@"C:\Playlist Music\Hip Hob Br\Marginais Boombap.wav");
                                musicOptions(thisOpDuringMusic, thisProgram);
                                break;
                            case 0:
                                thisProgram.exitMusic = 0;
                                break;
                        }
                        returnToFirstMusicWhenOpMusicEqualZero(thisProgram); //Quando estiver na primeira e escolher a opção de voltar uma musica ele mantém na primeira e apenas reinicia a música.
                    } while (thisProgram.exitMusic != 0);
                } //Hip Hob Br options FINISH
                if (opGenre.Key == ConsoleKey.D2 || opGenre.Key == ConsoleKey.NumPad2) //Funk Options Start
                {
                    thisProgram.exitMusic = 1;
                    menuFunk();
                    var opMusicVar = Console.ReadKey();
                    thisProgram.opMusic = int.Parse(opMusicVar.KeyChar.ToString());
                    while (thisProgram.opMusic < 0 || thisProgram.opMusic > 5)
                    {
                        menuFunk();
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        WriteOnMiddle("Errooou! :/");
                        WriteOnMiddle("Desculpe mas a opção de música não existe.");
                        readOnMiddle("Tente novamente");
                        Console.ForegroundColor = ConsoleColor.White;
                        thisProgram.opMusic = int.Parse(Console.ReadLine());
                    }
                    do
                    {
                        switch (thisProgram.opMusic)
                        {
                            case 1: //KEVIN O CHRIS - EVOLUIU
                                exibirListening();
                                Console.ForegroundColor = ConsoleColor.Red;
                                WriteOnMiddle("| EVOLUIU |");
                                Console.ForegroundColor = ConsoleColor.DarkGray;
                                WriteOnMiddle("Kevin O Chris, Sodré");
                                Console.ResetColor();
                                callMusic(@"C:\Playlist Music\Funk\Kevin O Chris, Sodré - Evoluiu.wav");
                                musicOptions(thisOpDuringMusic, thisProgram);
                                break;
                            case 2: //MC Livinho - Brota na Penha
                                exibirListening();
                                Console.ForegroundColor = ConsoleColor.Red;
                                WriteOnMiddle("| BROTA NA PENHA |");
                                Console.ForegroundColor = ConsoleColor.DarkGray;
                                WriteOnMiddle("MC Livinho");
                                Console.ResetColor();
                                callMusic(@"C:\Playlist Music\Funk\MC Livinho - Brota na Penha.wav");
                                musicOptions(thisOpDuringMusic, thisProgram);
                                break;
                            case 3: //MC Livinho - Pilantragem
                                exibirListening();
                                Console.ForegroundColor = ConsoleColor.Red;
                                WriteOnMiddle("| PILANTRAGEM |");
                                Console.ForegroundColor = ConsoleColor.DarkGray;
                                WriteOnMiddle("MC Livinho");
                                Console.ResetColor();
                                callMusic(@"C:\Playlist Music\Funk\MC Livinho - Pilantragem.wav");
                                musicOptions(thisOpDuringMusic, thisProgram);
                                break;
                            case 4: //Dj Henrique de Ferraz, MC Nando, MC Luanzinho - Garupa 3
                                exibirListening();
                                Console.ForegroundColor = ConsoleColor.Red;
                                WriteOnMiddle("| GARUPA 3 |");
                                Console.ForegroundColor = ConsoleColor.DarkGray;
                                WriteOnMiddle("Dj Henrique de Ferraz, MC Nando, MC Luanzinho");
                                Console.ResetColor();
                                callMusic(@"C:\Playlist Music\Funk\Dj Henrique de Ferraz, MC Nando, MC Luanzinho - Garupa 3.wav");
                                musicOptions(thisOpDuringMusic, thisProgram);
                                break;
                            case 5: //MC NIEL, FP DO TREM BALA - JA FUI FELIZ COM ELA
                                exibirListening();
                                Console.ForegroundColor = ConsoleColor.Red;
                                WriteOnMiddle("| JA FUI FELIZ COM ELA |");
                                Console.ForegroundColor = ConsoleColor.DarkGray;
                                WriteOnMiddle("MC Niel, FP DO TREM BALA");
                                Console.ResetColor();
                                callMusic(@"C:\Playlist Music\Funk\MC NIEL, FP DO TREM BALA - JA FUI FELIZ COM ELA.wav");
                                musicOptions(thisOpDuringMusic, thisProgram);
                                break;
                            case 0:
                                thisProgram.exitMusic = 0;
                                break;
                        }
                        returnToFirstMusicWhenOpMusicEqualZero(thisProgram);
                    } while (thisProgram.exitMusic != 0);
                } //Funk options FINISH
                else if (opGenre.Key == ConsoleKey.D3 || opGenre.Key == ConsoleKey.NumPad3)
                {
                    thisProgram.exitMusic = 1;
                    menuHipHopGringo();
                    var opMusicVar = Console.ReadKey();
                    thisProgram.opMusic = int.Parse(opMusicVar.KeyChar.ToString());
                    while (thisProgram.opMusic < 0 || thisProgram.opMusic > 5)
                    {
                        menuHipHopGringo();
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        WriteOnMiddle("Errooou! :/");
                        WriteOnMiddle("Desculpe mas a opção de música não existe.");
                        readOnMiddle("Tente novamente");
                        opMusicVar = Console.ReadKey();
                        thisProgram.opMusic = int.Parse(opMusicVar.KeyChar.ToString());
                    }
                    do
                    {
                        switch (thisProgram.opMusic)
                        {
                            case 1: //Lil Baby x Gunna - Drip Too Hard
                                exibirListening();
                                Console.ForegroundColor = ConsoleColor.Red;
                                WriteOnMiddle("| DRIP TOO HARD |");
                                Console.ForegroundColor = ConsoleColor.DarkGray;
                                WriteOnMiddle("Lil Baby x Gunna");
                                Console.ResetColor();
                                callMusic(@"C:\Playlist Music\Hip Hop Gringo\Lil Baby x Gunna - Drip Too Hard.wav");
                                musicOptions(thisOpDuringMusic, thisProgram);
                                break;
                            case 2: //Lil Nas X - Old Town Road feat. Billy Ray Cyrus
                                exibirListening();
                                Console.ForegroundColor = ConsoleColor.Red;
                                WriteOnMiddle("| OLD TOWN ROAD |");
                                Console.ForegroundColor = ConsoleColor.DarkGray;
                                WriteOnMiddle("Lil Nas X, Billy Ray Cyrus");
                                Console.ResetColor();
                                callMusic(@"C:\Playlist Music\Hip Hop Gringo\Lil Nas X - Old Town Road feat. Billy Ray Cyrus.wav");
                                musicOptions(thisOpDuringMusic, thisProgram);
                                break;
                            case 3: //Logic - Homicide feat. Eminem
                                exibirListening();
                                Console.ForegroundColor = ConsoleColor.Red;
                                WriteOnMiddle("| HOMICIDE |");
                                Console.ForegroundColor = ConsoleColor.DarkGray;
                                WriteOnMiddle("Logic, Eminem");
                                Console.ResetColor();
                                callMusic(@"C:\Playlist Music\Hip Hop Gringo\Logic - Homicide feat. Eminem.wav");
                                musicOptions(thisOpDuringMusic, thisProgram);
                                break;
                            case 4: //Post Malone - Wow
                                exibirListening();
                                Console.ForegroundColor = ConsoleColor.Red;
                                WriteOnMiddle("| WOW |");
                                Console.ForegroundColor = ConsoleColor.DarkGray;
                                WriteOnMiddle("Post Malone");
                                Console.ResetColor();
                                callMusic(@"C:\Playlist Music\Hip Hop Gringo\Post Malone - Wow.wav");
                                musicOptions(thisOpDuringMusic, thisProgram);
                                break;
                            case 5: //Travis Scott - goosebumps ft. Kendrick Lamar
                                exibirListening();
                                Console.ForegroundColor = ConsoleColor.Red;
                                WriteOnMiddle("| GOOSEBUMPS |");
                                Console.ForegroundColor = ConsoleColor.DarkGray;
                                WriteOnMiddle("Travis Scott, Kendrick Lamar");
                                Console.ResetColor();
                                callMusic(@"C:\Playlist Music\Hip Hop Gringo\Travis Scott - goosebumps ft. Kendrick Lamar.wav");
                                musicOptions(thisOpDuringMusic, thisProgram);
                                break;
                            case 0:
                                thisProgram.exitMusic = 0;
                                break;
                        }
                        returnToFirstMusicWhenOpMusicEqualZero(thisProgram);
                    } while (thisProgram.exitMusic != 0);

                }
                else if (opGenre.Key == ConsoleKey.D0 || opGenre.Key == ConsoleKey.NumPad0)
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine("\n\n\n\n\n\n");
                    WriteOnMiddle("■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■");
                    Console.ForegroundColor = ConsoleColor.White;
                    WriteOnMiddle("■■   ╔══════════════════════════╗   ■■");
                    WriteOnMiddle("■■   ║     Tem certeza que      ║   ■■");
                    WriteOnMiddle("■■   ║    gostaria de sair ?    ║   ■■");
                    WriteOnMiddle("■■   ║ ──────────────────────── ║   ■■");
                    Console.Write("\t\t\t\t\t ■■   ║ "); Console.ForegroundColor = ConsoleColor.DarkGreen; Console.Write("|Y| YES"); Console.ForegroundColor = ConsoleColor.Red; Console.Write("           |N| NO"); Console.ForegroundColor = ConsoleColor.White; Console.WriteLine(" ║   ■■");
                    WriteOnMiddle("■■   ╚══════════════════════════╝   ■■");
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    WriteOnMiddle("■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■");
                    Console.ForegroundColor = ConsoleColor.Black;
                    opGenre = Console.ReadKey();
                    Console.ForegroundColor = ConsoleColor.White;
                    while (opGenre.Key != ConsoleKey.Y && opGenre.Key != ConsoleKey.N)
                    {
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.WriteLine("\n\n\n\n\n\n");
                        WriteOnMiddle("■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■");
                        Console.ForegroundColor = ConsoleColor.White;
                        WriteOnMiddle("■■   ╔══════════════════════════╗   ■■");
                        WriteOnMiddle("■■   ║     Tem certeza que      ║   ■■");
                        WriteOnMiddle("■■   ║    gostaria de sair ?    ║   ■■");
                        WriteOnMiddle("■■   ║ ──────────────────────── ║   ■■");
                        Console.Write("\t\t\t\t\t ■■   ║ "); Console.ForegroundColor = ConsoleColor.DarkGreen; Console.Write("|Y| YES"); Console.ForegroundColor = ConsoleColor.Red; Console.Write("           |N| NO"); Console.ForegroundColor = ConsoleColor.White; Console.WriteLine(" ║   ■■");
                        WriteOnMiddle("■■   ╚══════════════════════════╝   ■■");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        WriteOnMiddle("■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■");
                        Console.ForegroundColor = ConsoleColor.Black;
                        opGenre = Console.ReadKey();
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    switch(opGenre.Key)
                    {
                        case ConsoleKey.Y:
                            thisProgram.exitGenre = 0;
                            break;
                        case ConsoleKey.N:
                            thisProgram.exitGenre = 1;
                            break;
                    }
                    
                }
                //Genre options FINISH
            }while (thisProgram.exitGenre != 0);
            myPlayer.Stop();
            Console.Clear();
            Console.WriteLine("\n\n\n\n");
            WriteOnMiddle("■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■");
            Console.Write("");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("\t\t\t\t\t■■   "); Console.ForegroundColor = ConsoleColor.Cyan; Console.Write("MUITO OBRIGADO POR USAR!  "); Console.ForegroundColor = ConsoleColor.White; Console.WriteLine("■■");
            Console.Write("\t\t\t\t\t■■   "); Console.ForegroundColor = ConsoleColor.Cyan; Console.WriteLine("VOCÊ SAIRÁ EM        ");
            Console.ResetColor();
            System.Threading.Timer stateTimer = new System.Threading.Timer(new TimerCallback(timerExit), null, 0, 1000);
            Console.WriteLine("\n\t\t\t\t\t■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■");
            Console.Read();
        }
        public static void exibirListening()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            WriteOnMiddle("■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■\n");
            Console.ForegroundColor = ConsoleColor.White; Console.WriteLine("\t\t   ■■═════════════════════════════════════════════════════════════════════════════■■");
            Console.ForegroundColor = ConsoleColor.White; Console.WriteLine("\t\t   ■■                                                                             ■■");
            Console.ForegroundColor = ConsoleColor.White; Console.Write("\t\t   ■■"); Console.ForegroundColor = ConsoleColor.Green; Console.Write("    ██▓     ██▓  ██████ ▄▄██████▓▓█████  ███▄    █  ██▓ ███▄    █   ▄████    "); Console.ForegroundColor = ConsoleColor.White; Console.WriteLine("■■");
            Console.ForegroundColor = ConsoleColor.White; Console.Write("\t\t   ■■"); Console.ForegroundColor = ConsoleColor.Green; Console.Write("   ▓██▒    ▓██▒▒██    ▒ ▓  ██▒ ▓▒▓█   ▀  ██ ▀█   █ ▓██▒ ██ ▀█   █  ██▒ ▀█▒   "); Console.ForegroundColor = ConsoleColor.White; Console.WriteLine("■■");
            Console.ForegroundColor = ConsoleColor.White; Console.Write("\t\t   ■■"); Console.ForegroundColor = ConsoleColor.Green; Console.Write("   ▒██░    ▒██▒░ ▓██▄   ▒ ▓██░ ▒░▒███   ▓██  ▀█ ██▒▒██▒▓██  ▀█ ██▒▒██░▄▄▄░   "); Console.ForegroundColor = ConsoleColor.White; Console.WriteLine("■■");
            Console.ForegroundColor = ConsoleColor.White; Console.Write("\t\t   ■■"); Console.ForegroundColor = ConsoleColor.Green; Console.Write("   ▒██░    ░██░  ▒   ██▒░ ▓██▓ ░ ▒██  ▄ ▓██▒  ▐▌██▒░██░▓██▒  ▐▌██▒░██  ██▓   "); Console.ForegroundColor = ConsoleColor.White; Console.WriteLine("■■");
            Console.ForegroundColor = ConsoleColor.White; Console.Write("\t\t   ■■"); Console.ForegroundColor = ConsoleColor.Green; Console.Write("   ░██████▒░██░▒██████▒▒  ▒██▒ ░ ░▒████▒▒██░   ▓██░░██░▒██░   ▓██░░▒████▀▒   "); Console.ForegroundColor = ConsoleColor.White; Console.WriteLine("■■");
            Console.ForegroundColor = ConsoleColor.White; Console.Write("\t\t   ■■"); Console.ForegroundColor = ConsoleColor.Green; Console.Write("   ░ ▒░▓  ░░▓  ▒ ▒▓▒ ▒ ░  ▒ ░░   ░░ ▒░ ░░ ▒░   ▒ ▒ ░▓  ░ ▒░   ▒ ▒  ░▒   ▒    "); Console.ForegroundColor = ConsoleColor.White; Console.WriteLine("■■");
            Console.ForegroundColor = ConsoleColor.White; Console.Write("\t\t   ■■"); Console.ForegroundColor = ConsoleColor.Green; Console.Write("   ░ ░ ▒  ░ ▒ ░░ ░▒  ░ ░    ░     ░ ░  ░░ ░░   ░ ▒░ ▒ ░░ ░░   ░ ▒░  ░   ░    "); Console.ForegroundColor = ConsoleColor.White; Console.WriteLine("■■");
            Console.ForegroundColor = ConsoleColor.White; Console.Write("\t\t   ■■"); Console.ForegroundColor = ConsoleColor.Green; Console.Write("     ░ ░    ▒ ░░  ░  ░    ░         ░      ░   ░ ░  ▒ ░   ░   ░ ░ ░ ░   ░    "); Console.ForegroundColor = ConsoleColor.White; Console.WriteLine("■■");
            Console.ForegroundColor = ConsoleColor.White; Console.Write("\t\t   ■■"); Console.ForegroundColor = ConsoleColor.Green; Console.Write("       ░  ░ ░        ░              ░  ░         ░  ░           ░       ░    "); Console.ForegroundColor = ConsoleColor.White; Console.WriteLine("■■");
            Console.ForegroundColor = ConsoleColor.White; Console.WriteLine("\t\t   ■■                                                                             ■■");
            Console.ForegroundColor = ConsoleColor.White; Console.Write("\t\t   ■■═════════════════════════════════════════════════════════════════════════════■■");
            Console.ResetColor();
        }
        public static void returnToFirstMusicWhenOpMusicEqualZero(Program program)
        {
            if(program.opMusic == 0 || program.opMusic == 6)
            {
                program.opMusic = 1;
            }
        }
        public static void musicOptions(OpDuringMusic opDuringMusic, Program program)
        {
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("\n\t\t\t\t\t\t  █  ▄█  ▄█  █▄  █▄  █         ▄█  \n\t\t\t\t\t\t  █■███■███  ███■███■█       ■██■■■■■■▄\n\t\t\t\t\t\t  █  ▀█  ▀█  █▀  █▀  █         ▀█   ■■▀");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("\n\t\t\t\t\t\t    ╔───╗      ╔───╗            ╔───╗\n\t\t\t\t\t\t    │ P │      │ N │            │ E │\n\t\t\t\t\t\t    ╚───╝      ╚───╝            ╚───╝");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            WriteOnMiddle("■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■");
            Console.ForegroundColor = ConsoleColor.Black;
            var OpDuringMusic = Console.ReadKey();
            Console.ForegroundColor = ConsoleColor.White;

            while (OpDuringMusic.Key != ConsoleKey.N && OpDuringMusic.Key != ConsoleKey.P && OpDuringMusic.Key != ConsoleKey.E)
            {
                Console.Clear();
                exibirListening();
                Console.ForegroundColor = ConsoleColor.Red;
                WriteOnMiddle("| COMANDOS |");
                Console.ForegroundColor = ConsoleColor.DarkGray;
                WriteOnMiddle(" ─────────────────────────────────────────────────────────── ");
                WriteOnMiddle(" |P| Previous Music |N| Next Music |E| Return to Musics List ");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("\n\t\t\t\t\t    █  ▄█  ▄█  █▄  █▄  █    ▄█  \n\t\t\t\t\t    █■███■███  ███■███■█  ■██■■■■■■▄\n\t\t\t\t\t    █  ▀█  ▀█  █▀  █▀  █    ▀█   ■■▀\n");
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("\t\t\t\t\t      ╔───╗      ╔───╗       ╔───╗\n\t\t\t\t\t      │ P │      │ N │       │ E │\n\t\t\t\t\t      ╚───╝      ╚───╝       ╚───╝");
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                WriteOnMiddle("■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■");
                Console.ForegroundColor = ConsoleColor.Black;
                OpDuringMusic = Console.ReadKey();
                Console.ForegroundColor = ConsoleColor.White;
            }
            if (OpDuringMusic.Key == ConsoleKey.N)
            {
                program.opMusic = program.opMusic + 1;
            }
            else
            {
                if (OpDuringMusic.Key == ConsoleKey.P)
                {
                    program.opMusic = program.opMusic - 1;
                }
                else
                {
                    program.exitMusic = 0;
                }
            }
        }

        static public void timerExit(Object obj)
        {
            if (Contador >= 0)
            {
                Console.Clear();
                Console.WriteLine("\n\n\n\n");
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                WriteOnMiddle("■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■");
                Console.Write("");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("\t\t\t\t\t   ■■   "); Console.ForegroundColor = ConsoleColor.Cyan; Console.Write("MUITO OBRIGADO POR USAR!  "); Console.ForegroundColor = ConsoleColor.White; Console.WriteLine("■■");
                Console.Write("\t\t\t\t\t   ■■   "); Console.ForegroundColor = ConsoleColor.Cyan; Console.Write("VOCÊ SAIRÁ EM      ");
                Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write(String.Format("{0:00}", Contador)); Console.ForegroundColor = ConsoleColor.White; Console.WriteLine("     ■■");
                Console.WriteLine("\t\t\t\t\t   ■■                             ■■");
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("\t\t\t\t\t■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■");
                Contador--;
                while (Contador == -1)
                {
                    Console.Clear();
                    Console.WriteLine("\n\n\n\n");
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    WriteOnMiddle("■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■");
                    Console.Write("");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("\t\t\t\t\t   ■■   "); Console.ForegroundColor = ConsoleColor.Cyan; Console.Write("MUITO OBRIGADO POR USAR!  "); Console.ForegroundColor = ConsoleColor.White; Console.WriteLine("■■");
                    Console.Write("\t\t\t\t\t   ■■   "); Console.ForegroundColor = ConsoleColor.Cyan; Console.Write("VOCÊ SAIRÁ EM      ");
                    Console.ResetColor();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write(String.Format("00")); Console.ForegroundColor = ConsoleColor.White; Console.WriteLine("     ■■");
                    Console.Write("\t\t\t\t\t   ■■          "); Console.ForegroundColor = ConsoleColor.Red; Console.Write("Saindo...          "); Console.ForegroundColor = ConsoleColor.White; Console.WriteLine("■■");
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine("\t\t\t\t\t■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■");
                    Contador--;
                }
            }
            else
            {
                Environment.Exit(0);
            }
        }
        private static int Contador = 3;
        public static void callMusic(string soundLocation)
        {
            var myPlayer = new System.Media.SoundPlayer();
            myPlayer.SoundLocation = soundLocation;
            myPlayer.Play();
            
        }
        static void WriteOnMiddle(string text)
        {
            Console.SetCursorPosition((Console.WindowWidth - text.Length) / 2, Console.CursorTop);
            Console.WriteLine(text);
        }
        static void WriteOnMiddle2(string text)
        {
            Console.SetCursorPosition((Console.WindowWidth - text.Length) / 2, Console.CursorTop);
            Console.Write(text);
        }
        static void readOnMiddle(string textTwo)
        {
            Console.SetCursorPosition((Console.WindowWidth - textTwo.Length) / 2, Console.CursorTop);
            Console.Write(textTwo);
        }
        private static void menuGenero()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("\n\n\n\n\n");
            WriteOnMiddle("■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■");
            Console.ForegroundColor = ConsoleColor.White;
            WriteOnMiddle("■■    ┌─────────┐                   ■■");
            Console.Write("\t\t\t\t\t ■■   ╔|");Console.ForegroundColor = ConsoleColor.DarkGreen; Console.Write("PLAYLISTS"); Console.ForegroundColor = ConsoleColor.White; Console.WriteLine("|═══════════════╗   ■■");
            WriteOnMiddle("■■   ║└─────────┘               ║   ■■");
            WriteOnMiddle("■■   ║ |1| Hip Hop BR           ║   ■■");
            WriteOnMiddle("■■   ║ |2| Funk                 ║   ■■");
            WriteOnMiddle("■■   ║ |3| Hip Hop Gringo       ║   ■■");
            WriteOnMiddle("■■   ║ ──────────────────────── ║   ■■");
            Console.Write("\t\t\t\t\t ■■   ║ "); Console.ForegroundColor = ConsoleColor.Red; Console.Write("|0| Sair do programa"); Console.ForegroundColor = ConsoleColor.White; Console.WriteLine("     ║   ■■");
            WriteOnMiddle("■■   ╚══════════════════════════╝   ■■");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            WriteOnMiddle("■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■");
            Console.ResetColor();
        }
        private static void menuHipHopBr()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("\n\n\n\n\n");
            WriteOnMiddle("■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■");
            Console.ForegroundColor = ConsoleColor.White;
            WriteOnMiddle("■■    ┌───────┐                                         ■■");
            Console.Write("\t\t\t       ■■   ╔|"); Console.ForegroundColor = ConsoleColor.DarkGreen; Console.Write("Músicas"); Console.ForegroundColor = ConsoleColor.White; Console.WriteLine("|═════════════════════════════════════╗   ■■");
            WriteOnMiddle("■■   ║└───────┘                                     ║   ■■");
            WriteOnMiddle("■■   ║  |1| Sidoka - Porsche                        ║   ■■");
            WriteOnMiddle("■■   ║  |2| Dudu, VK MAC - WTF(Astro)               ║   ■■");
            WriteOnMiddle("■■   ║  |3| Buddy, OIK - Marca Um 10                ║   ■■");
            WriteOnMiddle("■■   ║  |4| Muzzike,Deryck, Cabrera,... - JETFLIX   ║   ■■");
            WriteOnMiddle("■■   ║  |5| FELP 22, Predell... - Marginais Boombap ║   ■■");
            WriteOnMiddle("■■   ║ ──────────────────────────────────────────── ║   ■■");
            Console.Write("\t\t\t       ■■   ║  "); Console.ForegroundColor = ConsoleColor.DarkGreen; Console.Write("|0| Playlists"); Console.ForegroundColor = ConsoleColor.White; Console.WriteLine("                               ║   ■■");
            WriteOnMiddle("■■   ╚══════════════════════════════════════════════╝   ■■");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            WriteOnMiddle("■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■");
            Console.ResetColor();
        }
        private static void menuFunk()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("\n\n\n\n\n");
            WriteOnMiddle("■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■");
            Console.ForegroundColor = ConsoleColor.White;
            WriteOnMiddle("■■    ┌───────┐                                   ■■");
            Console.Write("\t\t\t\t  ■■   ╔|"); Console.ForegroundColor = ConsoleColor.DarkGreen;Console.Write("MÚSICAS"); Console.ForegroundColor = ConsoleColor.White;Console.WriteLine("|═══════════════════════════════╗   ■■");
            WriteOnMiddle("■■   ║└───────┘                               ║   ■■");
            WriteOnMiddle("■■   ║  |1| Kevin O Chris, Sodré - Evoluiu    ║   ■■");
            WriteOnMiddle("■■   ║  |2| MC Livinho - Brota na Penha       ║   ■■");
            WriteOnMiddle("■■   ║  |3| MC Livinho - Pilantragem          ║   ■■");
            WriteOnMiddle("■■   ║  |4| Dj Henrique de Ferraz - Garupa 3  ║   ■■");
            WriteOnMiddle("■■   ║  |5| MC NIEL - JA FUI FELIZ COM ELA    ║   ■■");
            WriteOnMiddle("■■   ║ ────────────────────────────────────── ║   ■■");
            Console.Write("\t\t\t\t  ■■   ║  "); Console.ForegroundColor = ConsoleColor.DarkGreen; Console.Write("|0| Playlists"); Console.ForegroundColor = ConsoleColor.White; Console.WriteLine("                         ║   ■■");
            WriteOnMiddle("■■   ╚════════════════════════════════════════╝   ■■");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            WriteOnMiddle("■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■");
            Console.ResetColor();
        }
        private static void menuHipHopGringo()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("\n\n\n\n\n");
            WriteOnMiddle("■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■");
            Console.ForegroundColor = ConsoleColor.White;
            WriteOnMiddle("■■    ┌───────┐                                           ■■");
            Console.Write("\t\t\t      ■■   ╔|"); Console.ForegroundColor = ConsoleColor.DarkGreen; Console.Write("MÚSICAS"); Console.ForegroundColor = ConsoleColor.White;Console.WriteLine("|═══════════════════════════════════════╗   ■■");
            WriteOnMiddle("■■   ║└───────┘                                       ║   ■■");
            WriteOnMiddle("■■   ║  |1| Lil Baby x Gunna - Drip Too Hard          ║   ■■");
            WriteOnMiddle("■■   ║  |2| Lil Nas X,Billy Ray Cyrus - Old Town Road ║   ■■");
            WriteOnMiddle("■■   ║  |3| Logic, Eminem - Homicide                  ║   ■■");
            WriteOnMiddle("■■   ║  |4| Post Malone - Wow                         ║   ■■");
            WriteOnMiddle("■■   ║  |5| Travis Scott, Kendrick Lamar - goosebumps ║   ■■");
            WriteOnMiddle("■■   ║ ────────────────────────────────────────────── ║   ■■");
            Console.Write("\t\t\t      ■■   ║  ");Console.ForegroundColor = ConsoleColor.DarkGreen; Console.Write ("|0| Playlists"); Console.ForegroundColor = ConsoleColor.White; Console.WriteLine("                                 ║   ■■");
            WriteOnMiddle("■■   ╚════════════════════════════════════════════════╝   ■■");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            WriteOnMiddle("■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■");
            Console.ResetColor();
        }
        private static void LinhaExtensa()
        {
            WriteOnMiddle("■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■");
        }
    
    }
}
