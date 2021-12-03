using System;
using System.Windows.Forms;
using System.IO;


namespace Ajedrez
{
    public partial class Form1 : Form
    {
        public static int vecesClickeadoJugador;
        public static int clickX;
        public static int clickY;
        public static int iMouse;
        public static int jMouse;
        public static int rankClicked;
        public static String columnaClikeada;

        public Form1()
        {
            InitializeComponent();
        }

        private void button_exit_Click(object sender, EventArgs e)
        {
            Form1.Ajedrez_main.ajedrez_sw1.Close();
            this.Close();
        }

        private void skakiera_Click(object sender, EventArgs e)
        {
            MessageBox.Show("skakiera clicked");
        }


        private void RedibujarSkakiera(string[,] rS)
        {
            string ubicacionPieza = "";
            string ubicacion = Directory.GetCurrentDirectory();

            for (int i = 0; i <= 7; i++)
            {
                for (int j = 0; j <= 7; j++)
                {
                    ubicacionPieza = "";

                    if (rS[(i), (j)].CompareTo("White Pawn") == 0)
                        ubicacionPieza = "\\Resources\\WPawn.gif";
                    else if (rS[(i), (j)].CompareTo("White Rook") == 0)
                        ubicacionPieza = "\\Resources\\WRook.gif";
                    else if (rS[(i), (j)].CompareTo("White Knight") == 0)
                        ubicacionPieza = "\\Resources\\WKnight.gif";
                    else if (rS[(i), (j)].CompareTo("White Bishop") == 0)
                        ubicacionPieza = "\\Resources\\WBishop.gif";
                    else if (rS[(i), (j)].CompareTo("White Queen") == 0)
                        ubicacionPieza = "\\Resources\\WQueen.gif";
                    else if (rS[(i), (j)].CompareTo("White King") == 0)
                        ubicacionPieza = "\\Resources\\WKing.gif";
                    else if (rS[(i), (j)].CompareTo("Black Pawn") == 0)
                        ubicacionPieza = "\\Resources\\BPawn.gif";
                    else if (rS[(i), (j)].CompareTo("Black Rook") == 0)
                        ubicacionPieza = "\\Resources\\BRook.gif";
                    else if (rS[(i), (j)].CompareTo("Black Knight") == 0)
                        ubicacionPieza = "\\Resources\\BKnight.gif";
                    else if (rS[(i), (j)].CompareTo("Black Bishop") == 0)
                        ubicacionPieza = "\\Resources\\BBishop.gif";
                    else if (rS[(i), (j)].CompareTo("Black Queen") == 0)
                        ubicacionPieza = "\\Resources\\BQueen.gif";
                    else if (rS[(i), (j)].CompareTo("Black King") == 0)
                        ubicacionPieza = "\\Resources\\BKing.gif";
                    else if (rS[(i), (j)].CompareTo("") == 0)
                        ubicacionPieza = "\\Resources\\nothing.gif";

                    if ((i == 0) & (j == 0))
                        pictureBoxA1.Load(string.Concat(ubicacion, ubicacionPieza));
                    else if ((i == 0) & (j == 1))
                        pictureBoxA2.Load(string.Concat(ubicacion, ubicacionPieza));
                    else if ((i == 0) & (j == 2))
                        pictureBoxA3.Load(string.Concat(ubicacion, ubicacionPieza));
                    else if ((i == 0) & (j == 3))
                        pictureBoxA4.Load(string.Concat(ubicacion, ubicacionPieza));
                    else if ((i == 0) & (j == 4))
                        pictureBoxA5.Load(string.Concat(ubicacion, ubicacionPieza));
                    else if ((i == 0) & (j == 5))
                        pictureBoxA6.Load(string.Concat(ubicacion, ubicacionPieza));
                    else if ((i == 0) & (j == 6))
                        pictureBoxA7.Load(string.Concat(ubicacion, ubicacionPieza));
                    else if ((i == 0) & (j == 7))
                        pictureBoxA8.Load(string.Concat(ubicacion, ubicacionPieza));

                    else if ((i == 1) & (j == 0))
                        pictureBoxB1.Load(string.Concat(ubicacion, ubicacionPieza));
                    else if ((i == 1) & (j == 1))
                        pictureBoxB2.Load(string.Concat(ubicacion, ubicacionPieza));
                    else if ((i == 1) & (j == 2))
                        pictureBoxB3.Load(string.Concat(ubicacion, ubicacionPieza));
                    else if ((i == 1) & (j == 3))
                        pictureBoxB4.Load(string.Concat(ubicacion, ubicacionPieza));
                    else if ((i == 1) & (j == 4))
                        pictureBoxB5.Load(string.Concat(ubicacion, ubicacionPieza));
                    else if ((i == 1) & (j == 5))
                        pictureBoxB6.Load(string.Concat(ubicacion, ubicacionPieza));
                    else if ((i == 1) & (j == 6))
                        pictureBoxB7.Load(string.Concat(ubicacion, ubicacionPieza));
                    else if ((i == 1) & (j == 7))
                        pictureBoxB8.Load(string.Concat(ubicacion, ubicacionPieza));

                    else if ((i == 2) & (j == 0))
                        pictureBoxC1.Load(string.Concat(ubicacion, ubicacionPieza));
                    else if ((i == 2) & (j == 1))
                        pictureBoxC2.Load(string.Concat(ubicacion, ubicacionPieza));
                    else if ((i == 2) & (j == 2))
                        pictureBoxC3.Load(string.Concat(ubicacion, ubicacionPieza));
                    else if ((i == 2) & (j == 3))
                        pictureBoxC4.Load(string.Concat(ubicacion, ubicacionPieza));
                    else if ((i == 2) & (j == 4))
                        pictureBoxC5.Load(string.Concat(ubicacion, ubicacionPieza));
                    else if ((i == 2) & (j == 5))
                        pictureBoxC6.Load(string.Concat(ubicacion, ubicacionPieza));
                    else if ((i == 2) & (j == 6))
                        pictureBoxC7.Load(string.Concat(ubicacion, ubicacionPieza));
                    else if ((i == 2) & (j == 7))
                        pictureBoxC8.Load(string.Concat(ubicacion, ubicacionPieza));

                    else if ((i == 3) & (j == 0))
                        pictureBoxD1.Load(string.Concat(ubicacion, ubicacionPieza));
                    else if ((i == 3) & (j == 1))
                        pictureBoxD2.Load(string.Concat(ubicacion, ubicacionPieza));
                    else if ((i == 3) & (j == 2))
                        pictureBoxD3.Load(string.Concat(ubicacion, ubicacionPieza));
                    else if ((i == 3) & (j == 3))
                        pictureBoxD4.Load(string.Concat(ubicacion, ubicacionPieza));
                    else if ((i == 3) & (j == 4))
                        pictureBoxD5.Load(string.Concat(ubicacion, ubicacionPieza));
                    else if ((i == 3) & (j == 5))
                        pictureBoxD6.Load(string.Concat(ubicacion, ubicacionPieza));
                    else if ((i == 3) & (j == 6))
                        pictureBoxD7.Load(string.Concat(ubicacion, ubicacionPieza));
                    else if ((i == 3) & (j == 7))
                        pictureBoxD8.Load(string.Concat(ubicacion, ubicacionPieza));

                    else if ((i == 4) & (j == 0))
                        pictureBoxE1.Load(string.Concat(ubicacion, ubicacionPieza));
                    else if ((i == 4) & (j == 1))
                        pictureBoxE2.Load(string.Concat(ubicacion, ubicacionPieza));
                    else if ((i == 4) & (j == 2))
                        pictureBoxE3.Load(string.Concat(ubicacion, ubicacionPieza));
                    else if ((i == 4) & (j == 3))
                        pictureBoxE4.Load(string.Concat(ubicacion, ubicacionPieza));
                    else if ((i == 4) & (j == 4))
                        pictureBoxE5.Load(string.Concat(ubicacion, ubicacionPieza));
                    else if ((i == 4) & (j == 5))
                        pictureBoxE6.Load(string.Concat(ubicacion, ubicacionPieza));
                    else if ((i == 4) & (j == 6))
                        pictureBoxE7.Load(string.Concat(ubicacion, ubicacionPieza));
                    else if ((i == 4) & (j == 7))
                        pictureBoxE8.Load(string.Concat(ubicacion, ubicacionPieza));

                    else if ((i == 5) & (j == 0))
                        pictureBoxF1.Load(string.Concat(ubicacion, ubicacionPieza));
                    else if ((i == 5) & (j == 1))
                        pictureBoxF2.Load(string.Concat(ubicacion, ubicacionPieza));
                    else if ((i == 5) & (j == 2))
                        pictureBoxF3.Load(string.Concat(ubicacion, ubicacionPieza));
                    else if ((i == 5) & (j == 3))
                        pictureBoxF4.Load(string.Concat(ubicacion, ubicacionPieza));
                    else if ((i == 5) & (j == 4))
                        pictureBoxF5.Load(string.Concat(ubicacion, ubicacionPieza));
                    else if ((i == 5) & (j == 5))
                        pictureBoxF6.Load(string.Concat(ubicacion, ubicacionPieza));
                    else if ((i == 5) & (j == 6))
                        pictureBoxF7.Load(string.Concat(ubicacion, ubicacionPieza));
                    else if ((i == 5) & (j == 7))
                        pictureBoxF8.Load(string.Concat(ubicacion, ubicacionPieza));

                    else if ((i == 6) & (j == 0))
                        pictureBoxG1.Load(string.Concat(ubicacion, ubicacionPieza));
                    else if ((i == 6) & (j == 1))
                        pictureBoxG2.Load(string.Concat(ubicacion, ubicacionPieza));
                    else if ((i == 6) & (j == 2))
                        pictureBoxG3.Load(string.Concat(ubicacion, ubicacionPieza));
                    else if ((i == 6) & (j == 3))
                        pictureBoxG4.Load(string.Concat(ubicacion, ubicacionPieza));
                    else if ((i == 6) & (j == 4))
                        pictureBoxG5.Load(string.Concat(ubicacion, ubicacionPieza));
                    else if ((i == 6) & (j == 5))
                        pictureBoxG6.Load(string.Concat(ubicacion, ubicacionPieza));
                    else if ((i == 6) & (j == 6))
                        pictureBoxG7.Load(string.Concat(ubicacion, ubicacionPieza));
                    else if ((i == 6) & (j == 7))
                        pictureBoxG8.Load(string.Concat(ubicacion, ubicacionPieza));

                    else if ((i == 7) & (j == 0))
                        pictureBoxH1.Load(string.Concat(ubicacion, ubicacionPieza));
                    else if ((i == 7) & (j == 1))
                        pictureBoxH2.Load(string.Concat(ubicacion, ubicacionPieza));
                    else if ((i == 7) & (j == 2))
                        pictureBoxH3.Load(string.Concat(ubicacion, ubicacionPieza));
                    else if ((i == 7) & (j == 3))
                        pictureBoxH4.Load(string.Concat(ubicacion, ubicacionPieza));
                    else if ((i == 7) & (j == 4))
                        pictureBoxH5.Load(string.Concat(ubicacion, ubicacionPieza));
                    else if ((i == 7) & (j == 5))
                        pictureBoxH6.Load(string.Concat(ubicacion, ubicacionPieza));
                    else if ((i == 7) & (j == 6))
                        pictureBoxH7.Load(string.Concat(ubicacion, ubicacionPieza));
                    else if ((i == 7) & (j == 7))
                        pictureBoxH8.Load(string.Concat(ubicacion, ubicacionPieza));
                }
            }

            Application.DoEvents();
        }

        class Ajedrez_main
        {

            public static StreamWriter ajedrez_sw1 = new StreamWriter("HUO_CHESS_LOG_Minimax_Thought_Process.txt", true);
            public static StreamWriter ajedrez_sw_attackers = new StreamWriter("HUO_CHESS_LOG_Attackers_Defenders.txt", true);

            public static String siguienteLinea;
            public static string posicionesFinales;

            public static String movimientoInutil = "N";
            public static bool movimientoPeligroso = false;
            public static bool piezaEnPeligro;
            public static bool checado;
            public static bool puedeComer;
            public static int valorPieza = 0;
            public static String[,] SkakieraLog = new String[8, 8];


            public static int[,] Skakiera_cuadros_peligro = new int[8, 8];
            public static int[,] numeroDefensores = new int[8, 8];
            public static int[,] numeroAtacantes = new int[8, 8];
            public static int[,] valorDefensores = new int[8, 8];
            public static int[,] valorAtacantes = new int[8, 8];
            public static bool posibleComerAtras;

            public static int valorPiezaMovidaHumano = 0;
            public static int valorPiezaMoviendose = 0;
            public static int temporalPuntajeJugador0;
            public static int temporalPuntajeMovimiento1Jugador;
            public static int temporalPuntajeMovimiento2;
            public static int temporalPuntajeMovimiento3Humano;
            public static int temporalPuntajeMovimiento4;
            public static int temporalPuntajeMovimiento5Jugador;
            public static int temporalPuntajeMovimiento6;

            public static int mejorSeleecion0, mejorSeleecion1, mejorSeleecion2, mejorSeleecion3, mejorSeleecion4;
            public static int[,] analisisNodo0 = new int[1000000, 6];
            public static int[,] analisisNodo1 = new int[1000000, 2];
            public static int[,] analisisNodo2 = new int[1000000, 2];
            public static int[,] analisisNodo03 = new int[10000000, 2];
            public static int[,] analisisNodo4 = new int[10000000, 2];
            public static int[] mejoresNodos0 = new int[10000000];
            public static int[] mejoresNodos1 = new int[10000000];
            public static int[] mejoresNodos2 = new int[10000000];
            public static int[] mejoresNodos3 = new int[10000000];
            public static int[] mejoresNodos4 = new int[10000000];
            public static int iniciarColumn1libre;
            public static int puntaje1Inicial;
            public static int m_FinishingColumnNumber1_public;
            public static int m_FinishingRank1_public;
            public static int m_StartingColumnNumber2_public;
            public static int m_StartingRank2_public;
            public static int m_FinishingColumnNumber2_public;
            public static int m_FinishingRank2_public;
            public static bool activateLogs;
            public static String Movimiento0;
            public static String Movimiento1;
            public static String Movimiento2;
            public static String Movimiento3;
            public static String Movimiento4;
            public static String[] Analisis0Nodo_Text = new String[1000000];
            public static String[] Analisis1Nodo_Text = new String[1000000];
            public static String[] Analisis2Nodo_Text = new String[1000000];
            public static String[] Analisis3Nodo_Text = new String[10000000];
            public static String[] Analisis4Nodo_Text = new String[10000000];
            public static String Best_Variant_text;
            public static String[,,] analisisnodo0Tablero = new String[8, 8, 1000000];
            public static String[,,] analisisnodo1Tablero = new String[8, 8, 1000000];
            public static String[,,] analisisnodo2Tablero = new String[8, 8, 1000000];
            public static String[,,] analisisnodo2Tablero2 = new String[8, 8, 1000000];
            public static String[,,] analisisnodo4Tablero4 = new String[8, 8, 1000000];
            public static String[,,] NodesAnalysis0_Chessboard_before = new String[8, 8, 1000000];
            public static String[,,] NodesAnalysis1_Chessboard_before = new String[8, 8, 1000000];
            public static String[,,] NodesAnalysis2_Chessboard_before = new String[8, 8, 1000000];


            public static int totalNodos;
            public static int cantidadNodoNivel0;
            public static int cantidadNodoNivel1;
            public static int cantidadNodoNivel2;
            public static int cantidadNodoNivel3;
            public static int cantidadNodoNivel4;
            public static int cantidadNodoNivel5;
            public static int cantidadNodoNivel6;

            public static int jugadorUltimoMovimientoColumn;
            public static int jugadorUltimoMovimientoRow;

            public static String[,] Skakiera = new String[8, 8];

            public static String mColorJugsdor;
            public static String ActualJugando;
            public static String colorJugando;
            public static String piezaMoviendose;

            public static String ProsorinoKommati;
            public static String ProsorinoKommati_KingCheck;

            public static bool exit_elegxos_nomimothtas = false;
            public static int h;
            public static int p;
            public static int how_to_move_Rank;
            public static int comoMoverColumna;

            public static bool KingCheck = false;

            public static String m_StartingColumn;
            public static int m_StartingRank;
            public static String m_FinishingColumn;
            public static int m_FinishingRank;

            public static bool enpassant_occured;

            public static int movimeinto;
            public static int numeroMovimientosAnalizados;
            public static bool Promotion_Occured = false;
            public static bool Castling_Occured = false;
            public static int ColumnaReyBlanca;
            public static int RankingReyBlanco;
            public static int BlKingColumn;
            public static int BlKingRank;
            public static bool chequeoReyBlanco;
            public static bool BlackKingCheck;
            public static bool mejorMovimientoEncontrado;

            public static bool peligroDerecha;
            public static bool peligroIzquierda;
            public static bool peligroArriba;
            public static bool peligroAbajo;
            public static bool peligroArribaDerecha;
            public static bool peligroAbajoDerecha;
            public static bool peligroArribaIZquierda;
            public static bool peligroAbajoIzquierda;

            public static int iniciaColumnaBlancaRey;
            public static int RankingBlancaRey;
            public static int iniciaColumnaNegraRey;
            public static int RankingReyNegroInicial;

            public static int numeroColumnaInicial;
            public static int columnaFinaliza;

            public static bool m_OrthotitaKinisis;

            public static bool m_NomimotitaKinisis;
            public static bool m_WrongColumn;

            public static int i;
            public static int j;

            public static int ApophasiXristi = 1;
            public static int eleccionUsuario;
            public static String[,] Skakiera_Move_0 = new String[8, 8];
            public static String[,] Skakiera_Move_After = new String[8, 8];
            public static String[,] Skakiera_Thinking = new String[8, 8];
            public static String[,] Skakiera_CM_Check = new String[8, 8];
            public static int puntuacionMovimientoActual;
            public static int mejorMovimientoNumeroColumna;
            public static int mejorMovimientoFinalizarColumnNumer;
            public static int mejorMovimientoRankingInicial;
            public static int mejorMovimientoRankFinalizar;
            public static int movimientoAnalizado;
            public static bool detenerAnalisis;
            public static int revisarProfundo;
            public static int m_StartingColumnNumber_HY;
            public static int m_FinishingColumnNumber_HY;
            public static int m_StartingRank_HY;
            public static int m_FinishingRank_HY;
            public static bool First_Call;
            public static String quienEStaAnalizado;
            public static String moviendoPieza_HY;

            public static String HY_inicioColumnaTexto;
            public static String HY_Finishing_Column_Text;
            public static int enpassant_possible_target_rank;
            public static int enpassant_possible_target_column;


            public static String piezaMovidaPreviamente;
            public static int mejorMovimientoColumnNumberPrevio;
            public static int previoRankMejorMovimiento;
            public static bool MovimientoJugadorEncontradod;
            public static bool PatEncontrado;
            public static bool Mate_Found;
            public static int m_ColumnaNumeroInicial_mate;
            public static int m_ColumnaNumeroFinal_mate;
            public static int m_RankingInicial_mate;
            public static int m_RankFinal_mate;


            public static void Main_Console()
            {

                revisarProfundo = 4;
                activateLogs = false;


                if (revisarProfundo == 4)
                    MessageBox.Show("\nHuo Chess v0.992 by Spiros I. Kakos (huo)\n[C# Edition - Last updated: 2019, 2020, 2021]\n\nCURRENT EXPERIMENT:\nDepth 5 half-moves (Minimax Algorithm)\n\nWhat about a nice game of chess?", "Huo Chess W8", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else if (revisarProfundo == 2)
                    MessageBox.Show("\nHuo Chess v0.992 by Spiros I. Kakos (huo)\n[C# Edition - Last updated: 2019, 2020, 2021]\n\nCURRENT EXPERIMENT:\nDepth 3 half-moves (Minimax Algorithm)\n\nWhat about a nice game of chess?", "Huo Chess W8", MessageBoxButtons.OK, MessageBoxIcon.Information);

                if (activateLogs == true)
                {
                    MessageBox.Show("Logs are active!\rRemember to delete them after every run!!!", "Logs", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    MessageBox.Show("Logs are NOT active!\rRemember to activate them if you need analysis.\nSet activateLogs = true to do that.", "Logs", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

                movimeinto = 0;
                colorJugando = "White";
                Starting_position();

                if (ActualJugando.CompareTo("HY") == 0)
                {
                    movimeinto = 0;
                    movimientoAnalizado = 0;
                    detenerAnalisis = false;
                    First_Call = true;
                    mejorMovimientoEncontrado = false;
                    quienEStaAnalizado = "HY";
                    movimientoInteligenciaArtificial(Skakiera);

                    ActualJugando = "Human";
                    vecesClickeadoJugador = 0;
                }


            }

            public static bool ChequeoNegro(string[,] BCSkakiera)
            {


                bool chequeoRey;

                int klopa;



                for (i = 0; i <= 7; i++)
                {
                    for (j = 0; j <= 7; j++)
                    {

                        if (BCSkakiera[(i), (j)].CompareTo("Black King") == 0)
                        {
                            BlKingColumn = (i + 1);
                            BlKingRank = (j + 1);
                        }

                    }
                }


                chequeoRey = false;


                peligroDerecha = true;

                for (klopa = 1; klopa <= 7; klopa++)
                {
                    if (((BlKingColumn + klopa) <= 8) && (peligroDerecha == true))
                    {
                        if ((BCSkakiera[(BlKingColumn + klopa - 1), (BlKingRank - 1)].CompareTo("White Rook") == 0) || (BCSkakiera[(BlKingColumn + klopa - 1), (BlKingRank - 1)].CompareTo("White Queen") == 0))
                            chequeoRey = true;
                        else if ((BCSkakiera[(BlKingColumn + klopa - 1), (BlKingRank - 1)].CompareTo("Black Pawn") == 0) || (BCSkakiera[(BlKingColumn + klopa - 1), (BlKingRank - 1)].CompareTo("Black Rook") == 0) || (BCSkakiera[(BlKingColumn + klopa - 1), (BlKingRank - 1)].CompareTo("Black Knight") == 0) || (BCSkakiera[(BlKingColumn + klopa - 1), (BlKingRank - 1)].CompareTo("Black Bishop") == 0) || (BCSkakiera[(BlKingColumn + klopa - 1), (BlKingRank - 1)].CompareTo("Black Queen") == 0))
                            peligroDerecha = false;
                        else if ((BCSkakiera[(BlKingColumn + klopa - 1), (BlKingRank - 1)].CompareTo("White Pawn") == 0) || (BCSkakiera[(BlKingColumn + klopa - 1), (BlKingRank - 1)].CompareTo("White Knight") == 0) || (BCSkakiera[(BlKingColumn + klopa - 1), (BlKingRank - 1)].CompareTo("White Bishop") == 0) || (BCSkakiera[(BlKingColumn + klopa - 1), (BlKingRank - 1)].CompareTo("White King") == 0))
                            peligroDerecha = false;
                    }
                }

                peligroIzquierda = true;

                for (klopa = 1; klopa <= 7; klopa++)
                {
                    if (((BlKingColumn - klopa) >= 1) && (peligroIzquierda == true))
                    {
                        if ((BCSkakiera[(BlKingColumn - klopa - 1), (BlKingRank - 1)].CompareTo("White Rook") == 0) || (BCSkakiera[(BlKingColumn - klopa - 1), (BlKingRank - 1)].CompareTo("White Queen") == 0))
                            chequeoRey = true;
                        else if ((BCSkakiera[(BlKingColumn - klopa - 1), (BlKingRank - 1)].CompareTo("Black Pawn") == 0) || (BCSkakiera[(BlKingColumn - klopa - 1), (BlKingRank - 1)].CompareTo("Black Rook") == 0) || (BCSkakiera[(BlKingColumn - klopa - 1), (BlKingRank - 1)].CompareTo("Black Knight") == 0) || (BCSkakiera[(BlKingColumn - klopa - 1), (BlKingRank - 1)].CompareTo("Black Bishop") == 0) || (BCSkakiera[(BlKingColumn - klopa - 1), (BlKingRank - 1)].CompareTo("Black Queen") == 0))
                            peligroIzquierda = false;
                        else if ((BCSkakiera[(BlKingColumn - klopa - 1), (BlKingRank - 1)].CompareTo("White Pawn") == 0) || (BCSkakiera[(BlKingColumn - klopa - 1), (BlKingRank - 1)].CompareTo("White Knight") == 0) || (BCSkakiera[(BlKingColumn - klopa - 1), (BlKingRank - 1)].CompareTo("White Bishop") == 0) || (BCSkakiera[(BlKingColumn - klopa - 1), (BlKingRank - 1)].CompareTo("White King") == 0))
                            peligroIzquierda = false;
                    }
                }


                peligroArriba = true;

                for (klopa = 1; klopa <= 7; klopa++)
                {
                    if (((BlKingRank + klopa) <= 8) && (peligroArriba == true))
                    {
                        if ((BCSkakiera[(BlKingColumn - 1), (BlKingRank + klopa - 1)].CompareTo("White Rook") == 0) || (BCSkakiera[(BlKingColumn - 1), (BlKingRank + klopa - 1)].CompareTo("White Queen") == 0))
                            chequeoRey = true;
                        else if ((BCSkakiera[(BlKingColumn - 1), (BlKingRank + klopa - 1)].CompareTo("Black Pawn") == 0) || (BCSkakiera[(BlKingColumn - 1), (BlKingRank + klopa - 1)].CompareTo("Black Rook") == 0) || (BCSkakiera[(BlKingColumn - 1), (BlKingRank + klopa - 1)].CompareTo("Black Knight") == 0) || (BCSkakiera[(BlKingColumn - 1), (BlKingRank + klopa - 1)].CompareTo("Black Bishop") == 0) || (BCSkakiera[(BlKingColumn - 1), (BlKingRank + klopa - 1)].CompareTo("Black Queen") == 0))
                            peligroArriba = false;
                        else if ((BCSkakiera[(BlKingColumn - 1), (BlKingRank + klopa - 1)].CompareTo("White Pawn") == 0) || (BCSkakiera[(BlKingColumn - 1), (BlKingRank + klopa - 1)].CompareTo("White Knight") == 0) || (BCSkakiera[(BlKingColumn - 1), (BlKingRank + klopa - 1)].CompareTo("White Bishop") == 0) || (BCSkakiera[(BlKingColumn - 1), (BlKingRank + klopa - 1)].CompareTo("White King") == 0))
                            peligroArriba = false;
                    }
                }

                peligroAbajo = true;

                for (klopa = 1; klopa <= 7; klopa++)
                {
                    if (((BlKingRank - klopa) >= 1) && (peligroAbajo == true))
                    {
                        if ((BCSkakiera[(BlKingColumn - 1), (BlKingRank - klopa - 1)].CompareTo("White Rook") == 0) || (BCSkakiera[(BlKingColumn - 1), (BlKingRank - klopa - 1)].CompareTo("White Queen") == 0))
                            chequeoRey = true;
                        else if ((BCSkakiera[(BlKingColumn - 1), (BlKingRank - klopa - 1)].CompareTo("Black Pawn") == 0) || (BCSkakiera[(BlKingColumn - 1), (BlKingRank - klopa - 1)].CompareTo("Black Rook") == 0) || (BCSkakiera[(BlKingColumn - 1), (BlKingRank - klopa - 1)].CompareTo("Black Knight") == 0) || (BCSkakiera[(BlKingColumn - 1), (BlKingRank - klopa - 1)].CompareTo("Black Bishop") == 0) || (BCSkakiera[(BlKingColumn - 1), (BlKingRank - klopa - 1)].CompareTo("Black Queen") == 0))
                            peligroAbajo = false;
                        else if ((BCSkakiera[(BlKingColumn - 1), (BlKingRank - klopa - 1)].CompareTo("White Pawn") == 0) || (BCSkakiera[(BlKingColumn - 1), (BlKingRank - klopa - 1)].CompareTo("White Knight") == 0) || (BCSkakiera[(BlKingColumn - 1), (BlKingRank - klopa - 1)].CompareTo("White Bishop") == 0) || (BCSkakiera[(BlKingColumn - 1), (BlKingRank - klopa - 1)].CompareTo("White King") == 0))
                            peligroAbajo = false;
                    }
                }

                peligroArribaDerecha = true;

                for (klopa = 1; klopa <= 7; klopa++)
                {
                    if (((BlKingColumn + klopa) <= 8) && ((BlKingRank + klopa) <= 8) && (peligroArribaDerecha == true))
                    {
                        if ((BCSkakiera[(BlKingColumn + klopa - 1), (BlKingRank + klopa - 1)].CompareTo("White Bishop") == 0) || (BCSkakiera[(BlKingColumn + klopa - 1), (BlKingRank + klopa - 1)].CompareTo("White Queen") == 0))
                            chequeoRey = true;
                        else if ((BCSkakiera[(BlKingColumn + klopa - 1), (BlKingRank + klopa - 1)].CompareTo("Black Pawn") == 0) || (BCSkakiera[(BlKingColumn + klopa - 1), (BlKingRank + klopa - 1)].CompareTo("Black Rook") == 0) || (BCSkakiera[(BlKingColumn + klopa - 1), (BlKingRank + klopa - 1)].CompareTo("Black Knight") == 0) || (BCSkakiera[(BlKingColumn + klopa - 1), (BlKingRank + klopa - 1)].CompareTo("Black Bishop") == 0) || (BCSkakiera[(BlKingColumn + klopa - 1), (BlKingRank + klopa - 1)].CompareTo("Black Queen") == 0))
                            peligroArribaDerecha = false;
                        else if ((BCSkakiera[(BlKingColumn + klopa - 1), (BlKingRank + klopa - 1)].CompareTo("White Pawn") == 0) || (BCSkakiera[(BlKingColumn + klopa - 1), (BlKingRank + klopa - 1)].CompareTo("White Rook") == 0) || (BCSkakiera[(BlKingColumn + klopa - 1), (BlKingRank + klopa - 1)].CompareTo("White Knight") == 0) || (BCSkakiera[(BlKingColumn + klopa - 1), (BlKingRank + klopa - 1)].CompareTo("White King") == 0))
                            peligroArribaDerecha = false;
                    }
                }


                peligroAbajoIzquierda = true;

                for (klopa = 1; klopa <= 7; klopa++)
                {
                    if (((BlKingColumn - klopa) >= 1) && ((BlKingRank - klopa) >= 1) && (peligroAbajoIzquierda == true))
                    {
                        if ((BCSkakiera[(BlKingColumn - klopa - 1), (BlKingRank - klopa - 1)].CompareTo("White Bishop") == 0) || (BCSkakiera[(BlKingColumn - klopa - 1), (BlKingRank - klopa - 1)].CompareTo("White Queen") == 0))
                            chequeoRey = true;
                        else if ((BCSkakiera[(BlKingColumn - klopa - 1), (BlKingRank - klopa - 1)].CompareTo("Black Pawn") == 0) || (BCSkakiera[(BlKingColumn - klopa - 1), (BlKingRank - klopa - 1)].CompareTo("Black Rook") == 0) || (BCSkakiera[(BlKingColumn - klopa - 1), (BlKingRank - klopa - 1)].CompareTo("Black Knight") == 0) || (BCSkakiera[(BlKingColumn - klopa - 1), (BlKingRank - klopa - 1)].CompareTo("Black Bishop") == 0) || (BCSkakiera[(BlKingColumn - klopa - 1), (BlKingRank - klopa - 1)].CompareTo("Black Queen") == 0))
                            peligroAbajoIzquierda = false;
                        else if ((BCSkakiera[(BlKingColumn - klopa - 1), (BlKingRank - klopa - 1)].CompareTo("White Pawn") == 0) || (BCSkakiera[(BlKingColumn - klopa - 1), (BlKingRank - klopa - 1)].CompareTo("White Rook") == 0) || (BCSkakiera[(BlKingColumn - klopa - 1), (BlKingRank - klopa - 1)].CompareTo("White Knight") == 0) || (BCSkakiera[(BlKingColumn - klopa - 1), (BlKingRank - klopa - 1)].CompareTo("White King") == 0))
                            peligroAbajoIzquierda = false;
                    }
                }


                peligroAbajoDerecha = true;

                for (klopa = 1; klopa <= 7; klopa++)
                {
                    if (((BlKingColumn + klopa) <= 8) && ((BlKingRank - klopa) >= 1) && (peligroAbajoDerecha == true))
                    {
                        if ((BCSkakiera[(BlKingColumn + klopa - 1), (BlKingRank - klopa - 1)].CompareTo("White Bishop") == 0) || (BCSkakiera[(BlKingColumn + klopa - 1), (BlKingRank - klopa - 1)].CompareTo("White Queen") == 0))
                            chequeoRey = true;
                        else if ((BCSkakiera[(BlKingColumn + klopa - 1), (BlKingRank - klopa - 1)].CompareTo("Black Pawn") == 0) || (BCSkakiera[(BlKingColumn + klopa - 1), (BlKingRank - klopa - 1)].CompareTo("Black Rook") == 0) || (BCSkakiera[(BlKingColumn + klopa - 1), (BlKingRank - klopa - 1)].CompareTo("Black Knight") == 0) || (BCSkakiera[(BlKingColumn + klopa - 1), (BlKingRank - klopa - 1)].CompareTo("Black Bishop") == 0) || (BCSkakiera[(BlKingColumn + klopa - 1), (BlKingRank - klopa - 1)].CompareTo("Black Queen") == 0))
                            peligroAbajoDerecha = false;
                        else if ((BCSkakiera[(BlKingColumn + klopa - 1), (BlKingRank - klopa - 1)].CompareTo("White Pawn") == 0) || (BCSkakiera[(BlKingColumn + klopa - 1), (BlKingRank - klopa - 1)].CompareTo("White Rook") == 0) || (BCSkakiera[(BlKingColumn + klopa - 1), (BlKingRank - klopa - 1)].CompareTo("White Knight") == 0) || (BCSkakiera[(BlKingColumn + klopa - 1), (BlKingRank - klopa - 1)].CompareTo("White King") == 0))
                            peligroAbajoDerecha = false;
                    }
                }


                peligroArribaIZquierda = true;

                for (klopa = 1; klopa <= 7; klopa++)
                {
                    if (((BlKingColumn - klopa) >= 1) && ((BlKingRank + klopa) <= 8) && (peligroArribaIZquierda == true))
                    {
                        if ((BCSkakiera[(BlKingColumn - klopa - 1), (BlKingRank + klopa - 1)].CompareTo("White Bishop") == 0) || (BCSkakiera[(BlKingColumn - klopa - 1), (BlKingRank + klopa - 1)].CompareTo("White Queen") == 0))
                            chequeoRey = true;
                        else if ((BCSkakiera[(BlKingColumn - klopa - 1), (BlKingRank + klopa - 1)].CompareTo("Black Pawn") == 0) || (BCSkakiera[(BlKingColumn - klopa - 1), (BlKingRank + klopa - 1)].CompareTo("Black Rook") == 0) || (BCSkakiera[(BlKingColumn - klopa - 1), (BlKingRank + klopa - 1)].CompareTo("Black Knight") == 0) || (BCSkakiera[(BlKingColumn - klopa - 1), (BlKingRank + klopa - 1)].CompareTo("Black Bishop") == 0) || (BCSkakiera[(BlKingColumn - klopa - 1), (BlKingRank + klopa - 1)].CompareTo("Black Queen") == 0))
                            peligroArribaIZquierda = false;
                        else if ((BCSkakiera[(BlKingColumn - klopa - 1), (BlKingRank + klopa - 1)].CompareTo("White Pawn") == 0) || (BCSkakiera[(BlKingColumn - klopa - 1), (BlKingRank + klopa - 1)].CompareTo("White Rook") == 0) || (BCSkakiera[(BlKingColumn - klopa - 1), (BlKingRank + klopa - 1)].CompareTo("White Knight") == 0) || (BCSkakiera[(BlKingColumn - klopa - 1), (BlKingRank + klopa - 1)].CompareTo("White King") == 0))
                            peligroArribaIZquierda = false;
                    }
                }


                if (((BlKingColumn + 1) <= 8) && ((BlKingRank - 1) >= 1))
                {
                    if (BCSkakiera[(BlKingColumn + 1 - 1), (BlKingRank - 1 - 1)].CompareTo("White Pawn") == 0)
                    {
                        chequeoRey = true;
                    }
                }


                if (((BlKingColumn - 1) >= 1) && ((BlKingRank - 1) >= 1))
                {
                    if (BCSkakiera[(BlKingColumn - 1 - 1), (BlKingRank - 1 - 1)].CompareTo("White Pawn") == 0)
                    {
                        chequeoRey = true;
                    }
                }


                if (((BlKingColumn + 1) <= 8) && ((BlKingRank + 2) <= 8))
                    if (BCSkakiera[(BlKingColumn + 1 - 1), (BlKingRank + 2 - 1)].CompareTo("White Knight") == 0)
                        chequeoRey = true;

                if (((BlKingColumn + 2) <= 8) && ((BlKingRank - 1) >= 1))
                    if (BCSkakiera[(BlKingColumn + 2 - 1), (BlKingRank - 1 - 1)].CompareTo("White Knight") == 0)
                        chequeoRey = true;

                if (((BlKingColumn + 1) <= 8) && ((BlKingRank - 2) >= 1))
                    if (BCSkakiera[(BlKingColumn + 1 - 1), (BlKingRank - 2 - 1)].CompareTo("White Knight") == 0)
                        chequeoRey = true;

                if (((BlKingColumn - 1) >= 1) && ((BlKingRank - 2) >= 1))
                    if (BCSkakiera[(BlKingColumn - 1 - 1), (BlKingRank - 2 - 1)].CompareTo("White Knight") == 0)
                        chequeoRey = true;

                if (((BlKingColumn - 2) >= 1) && ((BlKingRank - 1) >= 1))
                    if (BCSkakiera[(BlKingColumn - 2 - 1), (BlKingRank - 1 - 1)].CompareTo("White Knight") == 0)
                        chequeoRey = true;

                if (((BlKingColumn - 2) >= 1) && ((BlKingRank + 1) <= 8))
                    if (BCSkakiera[(BlKingColumn - 2 - 1), (BlKingRank + 1 - 1)].CompareTo("White Knight") == 0)
                        chequeoRey = true;

                if (((BlKingColumn - 1) >= 1) && ((BlKingRank + 2) <= 8))
                    if (BCSkakiera[(BlKingColumn - 1 - 1), (BlKingRank + 2 - 1)].CompareTo("White Knight") == 0)
                        chequeoRey = true;

                if (((BlKingColumn + 2) <= 8) && ((BlKingRank + 1) <= 8))
                    if (BCSkakiera[(BlKingColumn + 2 - 1), (BlKingRank + 1 - 1)].CompareTo("White Knight") == 0)
                        chequeoRey = true;

                return chequeoRey;
            }


            public static bool chequeoBlanca(string[,] WCSkakiera)
            {
                bool ChequeoRey;
                int klopa;


                for (i = 0; i <= 7; i++)
                {
                    for (j = 0; j <= 7; j++)
                    {

                        if (WCSkakiera[(i), (j)].CompareTo("White King") == 0)
                        {
                            ColumnaReyBlanca = (i + 1);
                            RankingReyBlanco = (j + 1);
                        }

                    }
                }

                ChequeoRey = false;


                peligroDerecha = true;

                for (klopa = 1; klopa <= 7; klopa++)
                {
                    if (((ColumnaReyBlanca + klopa) <= 8) && (peligroDerecha == true))
                    {
                        if ((WCSkakiera[(ColumnaReyBlanca + klopa - 1), (RankingReyBlanco - 1)].CompareTo("Black Rook") == 0) || (WCSkakiera[(ColumnaReyBlanca + klopa - 1), (RankingReyBlanco - 1)].CompareTo("Black Queen") == 0))
                            ChequeoRey = true;
                        else if ((WCSkakiera[(ColumnaReyBlanca + klopa - 1), (RankingReyBlanco - 1)].CompareTo("White Pawn") == 0) || (WCSkakiera[(ColumnaReyBlanca + klopa - 1), (RankingReyBlanco - 1)].CompareTo("White Rook") == 0) || (WCSkakiera[(ColumnaReyBlanca + klopa - 1), (RankingReyBlanco - 1)].CompareTo("White Knight") == 0) || (WCSkakiera[(ColumnaReyBlanca + klopa - 1), (RankingReyBlanco - 1)].CompareTo("White Bishop") == 0) || (WCSkakiera[(ColumnaReyBlanca + klopa - 1), (RankingReyBlanco - 1)].CompareTo("White Queen") == 0))
                            peligroDerecha = false;
                        else if ((WCSkakiera[(ColumnaReyBlanca + klopa - 1), (RankingReyBlanco - 1)].CompareTo("Black Pawn") == 0) || (WCSkakiera[(ColumnaReyBlanca + klopa - 1), (RankingReyBlanco - 1)].CompareTo("Black Knight") == 0) || (WCSkakiera[(ColumnaReyBlanca + klopa - 1), (RankingReyBlanco - 1)].CompareTo("Black Bishop") == 0) || (WCSkakiera[(ColumnaReyBlanca + klopa - 1), (RankingReyBlanco - 1)].CompareTo("Black King") == 0))
                            peligroDerecha = false;
                    }
                }

                peligroIzquierda = true;

                for (klopa = 1; klopa <= 7; klopa++)
                {
                    if (((ColumnaReyBlanca - klopa) >= 1) && (peligroIzquierda == true))
                    {
                        if ((WCSkakiera[(ColumnaReyBlanca - klopa - 1), (RankingReyBlanco - 1)].CompareTo("Black Rook") == 0) || (WCSkakiera[(ColumnaReyBlanca - klopa - 1), (RankingReyBlanco - 1)].CompareTo("Black Queen") == 0))
                            ChequeoRey = true;
                        else if ((WCSkakiera[(ColumnaReyBlanca - klopa - 1), (RankingReyBlanco - 1)].CompareTo("White Pawn") == 0) || (WCSkakiera[(ColumnaReyBlanca - klopa - 1), (RankingReyBlanco - 1)].CompareTo("White Rook") == 0) || (WCSkakiera[(ColumnaReyBlanca - klopa - 1), (RankingReyBlanco - 1)].CompareTo("White Knight") == 0) || (WCSkakiera[(ColumnaReyBlanca - klopa - 1), (RankingReyBlanco - 1)].CompareTo("White Bishop") == 0) || (WCSkakiera[(ColumnaReyBlanca - klopa - 1), (RankingReyBlanco - 1)].CompareTo("White Queen") == 0))
                            peligroIzquierda = false;
                        else if ((WCSkakiera[(ColumnaReyBlanca - klopa - 1), (RankingReyBlanco - 1)].CompareTo("Black Pawn") == 0) || (WCSkakiera[(ColumnaReyBlanca - klopa - 1), (RankingReyBlanco - 1)].CompareTo("Black Knight") == 0) || (WCSkakiera[(ColumnaReyBlanca - klopa - 1), (RankingReyBlanco - 1)].CompareTo("Black Bishop") == 0) || (WCSkakiera[(ColumnaReyBlanca - klopa - 1), (RankingReyBlanco - 1)].CompareTo("Black King") == 0))
                            peligroIzquierda = false;
                    }
                }

                peligroArriba = true;

                for (klopa = 1; klopa <= 7; klopa++)
                {
                    if (((RankingReyBlanco + klopa) <= 8) && (peligroArriba == true))
                    {
                        if ((WCSkakiera[(ColumnaReyBlanca - 1), (RankingReyBlanco + klopa - 1)].CompareTo("Black Rook") == 0) || (WCSkakiera[(ColumnaReyBlanca - 1), (RankingReyBlanco + klopa - 1)].CompareTo("Black Queen") == 0))
                            ChequeoRey = true;
                        else if ((WCSkakiera[(ColumnaReyBlanca - 1), (RankingReyBlanco + klopa - 1)].CompareTo("White Pawn") == 0) || (WCSkakiera[(ColumnaReyBlanca - 1), (RankingReyBlanco + klopa - 1)].CompareTo("White Rook") == 0) || (WCSkakiera[(ColumnaReyBlanca - 1), (RankingReyBlanco + klopa - 1)].CompareTo("White Knight") == 0) || (WCSkakiera[(ColumnaReyBlanca - 1), (RankingReyBlanco + klopa - 1)].CompareTo("White Bishop") == 0) || (WCSkakiera[(ColumnaReyBlanca - 1), (RankingReyBlanco + klopa - 1)].CompareTo("White Queen") == 0))
                            peligroArriba = false;
                        else if ((WCSkakiera[(ColumnaReyBlanca - 1), (RankingReyBlanco + klopa - 1)].CompareTo("Black Pawn") == 0) || (WCSkakiera[(ColumnaReyBlanca - 1), (RankingReyBlanco + klopa - 1)].CompareTo("Black Knight") == 0) || (WCSkakiera[(ColumnaReyBlanca - 1), (RankingReyBlanco + klopa - 1)].CompareTo("Black Bishop") == 0) || (WCSkakiera[(ColumnaReyBlanca - 1), (RankingReyBlanco + klopa - 1)].CompareTo("Black King") == 0))
                            peligroArriba = false;
                    }
                }

                peligroAbajo = true;

                for (klopa = 1; klopa <= 7; klopa++)
                {
                    if (((RankingReyBlanco - klopa) >= 1) && (peligroAbajo == true))
                    {
                        if ((WCSkakiera[(ColumnaReyBlanca - 1), (RankingReyBlanco - klopa - 1)].CompareTo("Black Rook") == 0) || (WCSkakiera[(ColumnaReyBlanca - 1), (RankingReyBlanco - klopa - 1)].CompareTo("Black Queen") == 0))
                            ChequeoRey = true;
                        else if ((WCSkakiera[(ColumnaReyBlanca - 1), (RankingReyBlanco - klopa - 1)].CompareTo("White Pawn") == 0) || (WCSkakiera[(ColumnaReyBlanca - 1), (RankingReyBlanco - klopa - 1)].CompareTo("White Rook") == 0) || (WCSkakiera[(ColumnaReyBlanca - 1), (RankingReyBlanco - klopa - 1)].CompareTo("White Knight") == 0) || (WCSkakiera[(ColumnaReyBlanca - 1), (RankingReyBlanco - klopa - 1)].CompareTo("White Bishop") == 0) || (WCSkakiera[(ColumnaReyBlanca - 1), (RankingReyBlanco - klopa - 1)].CompareTo("White Queen") == 0))
                            peligroAbajo = false;
                        else if ((WCSkakiera[(ColumnaReyBlanca - 1), (RankingReyBlanco - klopa - 1)].CompareTo("Black Pawn") == 0) || (WCSkakiera[(ColumnaReyBlanca - 1), (RankingReyBlanco - klopa - 1)].CompareTo("Black Knight") == 0) || (WCSkakiera[(ColumnaReyBlanca - 1), (RankingReyBlanco - klopa - 1)].CompareTo("Black Bishop") == 0) || (WCSkakiera[(ColumnaReyBlanca - 1), (RankingReyBlanco - klopa - 1)].CompareTo("Black King") == 0))
                            peligroAbajo = false;
                    }
                }

                peligroArribaDerecha = true;

                for (klopa = 1; klopa <= 7; klopa++)
                {
                    if (((ColumnaReyBlanca + klopa) <= 8) && ((RankingReyBlanco + klopa) <= 8) && (peligroArribaDerecha == true))
                    {
                        if ((WCSkakiera[(ColumnaReyBlanca + klopa - 1), (RankingReyBlanco + klopa - 1)].CompareTo("Black Bishop") == 0) || (WCSkakiera[(ColumnaReyBlanca + klopa - 1), (RankingReyBlanco + klopa - 1)].CompareTo("Black Queen") == 0))
                            ChequeoRey = true;
                        else if ((WCSkakiera[(ColumnaReyBlanca + klopa - 1), (RankingReyBlanco + klopa - 1)].CompareTo("White Pawn") == 0) || (WCSkakiera[(ColumnaReyBlanca + klopa - 1), (RankingReyBlanco + klopa - 1)].CompareTo("White Rook") == 0) || (WCSkakiera[(ColumnaReyBlanca + klopa - 1), (RankingReyBlanco + klopa - 1)].CompareTo("White Knight") == 0) || (WCSkakiera[(ColumnaReyBlanca + klopa - 1), (RankingReyBlanco + klopa - 1)].CompareTo("White Bishop") == 0) || (WCSkakiera[(ColumnaReyBlanca + klopa - 1), (RankingReyBlanco + klopa - 1)].CompareTo("White Queen") == 0))
                            peligroArribaDerecha = false;
                        else if ((WCSkakiera[(ColumnaReyBlanca + klopa - 1), (RankingReyBlanco + klopa - 1)].CompareTo("Black Pawn") == 0) || (WCSkakiera[(ColumnaReyBlanca + klopa - 1), (RankingReyBlanco + klopa - 1)].CompareTo("Black Rook") == 0) || (WCSkakiera[(ColumnaReyBlanca + klopa - 1), (RankingReyBlanco + klopa - 1)].CompareTo("Black Knight") == 0) || (WCSkakiera[(ColumnaReyBlanca + klopa - 1), (RankingReyBlanco + klopa - 1)].CompareTo("Black King") == 0))
                            peligroArribaDerecha = false;
                    }
                }

                peligroAbajoIzquierda = true;

                for (klopa = 1; klopa <= 7; klopa++)
                {
                    if (((ColumnaReyBlanca - klopa) >= 1) && ((RankingReyBlanco - klopa) >= 1) && (peligroAbajoIzquierda == true))
                    {
                        if ((WCSkakiera[(ColumnaReyBlanca - klopa - 1), (RankingReyBlanco - klopa - 1)].CompareTo("Black Bishop") == 0) || (WCSkakiera[(ColumnaReyBlanca - klopa - 1), (RankingReyBlanco - klopa - 1)].CompareTo("Black Queen") == 0))
                            ChequeoRey = true;
                        else if ((WCSkakiera[(ColumnaReyBlanca - klopa - 1), (RankingReyBlanco - klopa - 1)].CompareTo("White Pawn") == 0) || (WCSkakiera[(ColumnaReyBlanca - klopa - 1), (RankingReyBlanco - klopa - 1)].CompareTo("White Rook") == 0) || (WCSkakiera[(ColumnaReyBlanca - klopa - 1), (RankingReyBlanco - klopa - 1)].CompareTo("White Knight") == 0) || (WCSkakiera[(ColumnaReyBlanca - klopa - 1), (RankingReyBlanco - klopa - 1)].CompareTo("White Bishop") == 0) || (WCSkakiera[(ColumnaReyBlanca - klopa - 1), (RankingReyBlanco - klopa - 1)].CompareTo("White Queen") == 0))
                            peligroAbajoIzquierda = false;
                        else if ((WCSkakiera[(ColumnaReyBlanca - klopa - 1), (RankingReyBlanco - klopa - 1)].CompareTo("Black Pawn") == 0) || (WCSkakiera[(ColumnaReyBlanca - klopa - 1), (RankingReyBlanco - klopa - 1)].CompareTo("Black Rook") == 0) || (WCSkakiera[(ColumnaReyBlanca - klopa - 1), (RankingReyBlanco - klopa - 1)].CompareTo("Black Knight") == 0) || (WCSkakiera[(ColumnaReyBlanca - klopa - 1), (RankingReyBlanco - klopa - 1)].CompareTo("Black King") == 0))
                            peligroAbajoIzquierda = false;
                    }
                }

                peligroAbajoDerecha = true;

                for (klopa = 1; klopa <= 7; klopa++)
                {
                    if (((ColumnaReyBlanca + klopa) <= 8) && ((RankingReyBlanco - klopa) >= 1) && (peligroAbajoDerecha == true))
                    {
                        if ((WCSkakiera[(ColumnaReyBlanca + klopa - 1), (RankingReyBlanco - klopa - 1)].CompareTo("Black Bishop") == 0) || (WCSkakiera[(ColumnaReyBlanca + klopa - 1), (RankingReyBlanco - klopa - 1)].CompareTo("Black Queen") == 0))
                            ChequeoRey = true;
                        else if ((WCSkakiera[(ColumnaReyBlanca + klopa - 1), (RankingReyBlanco - klopa - 1)].CompareTo("White Pawn") == 0) || (WCSkakiera[(ColumnaReyBlanca + klopa - 1), (RankingReyBlanco - klopa - 1)].CompareTo("White Rook") == 0) || (WCSkakiera[(ColumnaReyBlanca + klopa - 1), (RankingReyBlanco - klopa - 1)].CompareTo("White Knight") == 0) || (WCSkakiera[(ColumnaReyBlanca + klopa - 1), (RankingReyBlanco - klopa - 1)].CompareTo("White Bishop") == 0) || (WCSkakiera[(ColumnaReyBlanca + klopa - 1), (RankingReyBlanco - klopa - 1)].CompareTo("White Queen") == 0))
                            peligroAbajoDerecha = false;
                        else if ((WCSkakiera[(ColumnaReyBlanca + klopa - 1), (RankingReyBlanco - klopa - 1)].CompareTo("Black Pawn") == 0) || (WCSkakiera[(ColumnaReyBlanca + klopa - 1), (RankingReyBlanco - klopa - 1)].CompareTo("Black Rook") == 0) || (WCSkakiera[(ColumnaReyBlanca + klopa - 1), (RankingReyBlanco - klopa - 1)].CompareTo("Black Knight") == 0) || (WCSkakiera[(ColumnaReyBlanca + klopa - 1), (RankingReyBlanco - klopa - 1)].CompareTo("Black King") == 0))
                            peligroAbajoDerecha = false;
                    }
                }


                peligroArribaIZquierda = true;

                for (klopa = 1; klopa <= 7; klopa++)
                {
                    if (((ColumnaReyBlanca - klopa) >= 1) && ((RankingReyBlanco + klopa) <= 8) && (peligroArribaIZquierda == true))
                    {
                        if ((WCSkakiera[(ColumnaReyBlanca - klopa - 1), (RankingReyBlanco + klopa - 1)].CompareTo("Black Bishop") == 0) || (WCSkakiera[(ColumnaReyBlanca - klopa - 1), (RankingReyBlanco + klopa - 1)].CompareTo("Black Queen") == 0))
                            ChequeoRey = true;
                        else if ((WCSkakiera[(ColumnaReyBlanca - klopa - 1), (RankingReyBlanco + klopa - 1)].CompareTo("White Pawn") == 0) || (WCSkakiera[(ColumnaReyBlanca - klopa - 1), (RankingReyBlanco + klopa - 1)].CompareTo("White Rook") == 0) || (WCSkakiera[(ColumnaReyBlanca - klopa - 1), (RankingReyBlanco + klopa - 1)].CompareTo("White Knight") == 0) || (WCSkakiera[(ColumnaReyBlanca - klopa - 1), (RankingReyBlanco + klopa - 1)].CompareTo("White Bishop") == 0) || (WCSkakiera[(ColumnaReyBlanca - klopa - 1), (RankingReyBlanco + klopa - 1)].CompareTo("White Queen") == 0))
                            peligroArribaIZquierda = false;
                        else if ((WCSkakiera[(ColumnaReyBlanca - klopa - 1), (RankingReyBlanco + klopa - 1)].CompareTo("Black Pawn") == 0) || (WCSkakiera[(ColumnaReyBlanca - klopa - 1), (RankingReyBlanco + klopa - 1)].CompareTo("Black Rook") == 0) || (WCSkakiera[(ColumnaReyBlanca - klopa - 1), (RankingReyBlanco + klopa - 1)].CompareTo("Black Knight") == 0) || (WCSkakiera[(ColumnaReyBlanca - klopa - 1), (RankingReyBlanco + klopa - 1)].CompareTo("Black King") == 0))
                            peligroArribaIZquierda = false;
                    }
                }


                if (((ColumnaReyBlanca + 1) <= 8) && ((RankingReyBlanco + 1) <= 8))
                {
                    if (WCSkakiera[(ColumnaReyBlanca + 1 - 1), (RankingReyBlanco + 1 - 1)].CompareTo("Black Pawn") == 0)
                    {
                        ChequeoRey = true;
                    }
                }


                if (((ColumnaReyBlanca - 1) >= 1) && ((RankingReyBlanco + 1) <= 8))
                {
                    if (WCSkakiera[(ColumnaReyBlanca - 1 - 1), (RankingReyBlanco + 1 - 1)].CompareTo("Black Pawn") == 0)
                    {
                        ChequeoRey = true;
                    }
                }


                if (((ColumnaReyBlanca + 1) <= 8) && ((RankingReyBlanco + 2) <= 8))
                    if (WCSkakiera[(ColumnaReyBlanca + 1 - 1), (RankingReyBlanco + 2 - 1)].CompareTo("Black Knight") == 0)
                        ChequeoRey = true;

                if (((ColumnaReyBlanca + 2) <= 8) && ((RankingReyBlanco - 1) >= 1))
                    if (WCSkakiera[(ColumnaReyBlanca + 2 - 1), (RankingReyBlanco - 1 - 1)].CompareTo("Black Knight") == 0)
                        ChequeoRey = true;

                if (((ColumnaReyBlanca + 1) <= 8) && ((RankingReyBlanco - 2) >= 1))
                    if (WCSkakiera[(ColumnaReyBlanca + 1 - 1), (RankingReyBlanco - 2 - 1)].CompareTo("Black Knight") == 0)
                        ChequeoRey = true;

                if (((ColumnaReyBlanca - 1) >= 1) && ((RankingReyBlanco - 2) >= 1))
                    if (WCSkakiera[(ColumnaReyBlanca - 1 - 1), (RankingReyBlanco - 2 - 1)].CompareTo("Black Knight") == 0)
                        ChequeoRey = true;

                if (((ColumnaReyBlanca - 2) >= 1) && ((RankingReyBlanco - 1) >= 1))
                    if (WCSkakiera[(ColumnaReyBlanca - 2 - 1), (RankingReyBlanco - 1 - 1)].CompareTo("Black Knight") == 0)
                        ChequeoRey = true;

                if (((ColumnaReyBlanca - 2) >= 1) && ((RankingReyBlanco + 1) <= 8))
                    if (WCSkakiera[(ColumnaReyBlanca - 2 - 1), (RankingReyBlanco + 1 - 1)].CompareTo("Black Knight") == 0)
                        ChequeoRey = true;

                if (((ColumnaReyBlanca - 1) >= 1) && ((RankingReyBlanco + 2) <= 8))
                    if (WCSkakiera[(ColumnaReyBlanca - 1 - 1), (RankingReyBlanco + 2 - 1)].CompareTo("Black Knight") == 0)
                        ChequeoRey = true;

                if (((ColumnaReyBlanca + 2) <= 8) && ((RankingReyBlanco + 1) <= 8))
                    if (WCSkakiera[(ColumnaReyBlanca + 2 - 1), (RankingReyBlanco + 1 - 1)].CompareTo("Black Knight") == 0)
                        ChequeoRey = true;

                return ChequeoRey;
            }


            public static void checarMovimiento(string[,] CMSkakiera, int m_StartingRankCM, int m_StartingColumnNumberCM, int m_FinishingRankCM, int m_FinishingColumnNumberCM, String MovingPieceCM)
            {
                #region WriteLog
                if (activateLogs == true)
                {
                    ajedrez_sw1.WriteLine("");
                    ajedrez_sw1.WriteLine("ChMo -- Entered CheckMove");
                    ajedrez_sw1.WriteLine(string.Concat("ChMo -- Depth analyzed: ", movimientoAnalizado.ToString()));
                    ajedrez_sw1.WriteLine(string.Concat("ChMo -- Number of moves analyzed: ", numeroMovimientosAnalizados.ToString()));
                    ajedrez_sw1.WriteLine(string.Concat("ChMo -- Move analyzed: ", m_StartingColumnNumber_HY.ToString(), m_StartingRank_HY.ToString(), " -> ", m_FinishingColumnNumber_HY.ToString(), m_FinishingRank_HY.ToString()));
                    ajedrez_sw1.WriteLine(string.Concat("ChMo -- Number of Nodes 0: ", cantidadNodoNivel0.ToString()));
                    ajedrez_sw1.WriteLine(string.Concat("ChMo -- Number of Nodes 1: ", cantidadNodoNivel1.ToString()));
                    ajedrez_sw1.WriteLine(string.Concat("ChMo -- Number of Nodes 2: ", cantidadNodoNivel2.ToString()));
                    ajedrez_sw1.WriteLine(string.Concat("ChMo -- Number of Nodes 3: ", cantidadNodoNivel3.ToString()));
                    ajedrez_sw1.WriteLine(string.Concat("ChMo -- Number of Nodes 4: ", cantidadNodoNivel4.ToString()));
                    ajedrez_sw1.WriteLine(string.Concat("ChMo -- Number of Nodes 5: ", cantidadNodoNivel5.ToString()));
                    ajedrez_sw1.WriteLine(string.Concat("ChMo -- Number of Nodes 6: ", cantidadNodoNivel6.ToString()));
                    ajedrez_sw1.WriteLine("");
                }
                #endregion WriteLog

                String ProsorinoKommatiCM;

                for (int iii = 0; iii <= 7; iii++)
                {
                    for (int jjj = 0; jjj <= 7; jjj++)
                    {
                        Skakiera_CM_Check[iii, jjj] = CMSkakiera[(iii), (jjj)];
                    }
                }

                numeroMovimientosAnalizados++;

                ActualJugando = "Human";
                m_WrongColumn = false;

                m_OrthotitaKinisis = ElegxosOrthotitas(CMSkakiera, 0, m_StartingRankCM, m_StartingColumnNumberCM, m_FinishingRankCM, m_FinishingColumnNumberCM, MovingPieceCM);
                if (m_OrthotitaKinisis == true)
                    m_NomimotitaKinisis = ElegxosNomimotitas(CMSkakiera, 0, m_StartingRankCM, m_StartingColumnNumberCM, m_FinishingRankCM, m_FinishingColumnNumberCM, MovingPieceCM);

                ActualJugando = "HY";

            }

            public static void movimientoInteligenciaArtificial(string[,] Skakiera_Thinking_init)
            {
                #region WriteLog
                if (activateLogs == true)
                {
                    ajedrez_sw1.WriteLine("");
                    ajedrez_sw1.WriteLine("CoMo -- Entered ComputerMove");
                    ajedrez_sw1.WriteLine(string.Concat("CoMo -- Depth analyzed: ", movimientoAnalizado.ToString()));
                    ajedrez_sw1.WriteLine(string.Concat("CoMo -- Number of moves analyzed: ", numeroMovimientosAnalizados.ToString()));
                    ajedrez_sw1.WriteLine(string.Concat("CoMo -- Move analyzed: ", m_StartingColumnNumber_HY.ToString(), m_StartingRank_HY.ToString(), " -> ", m_FinishingColumnNumber_HY.ToString(), m_FinishingRank_HY.ToString()));
                    ajedrez_sw1.WriteLine(string.Concat("CoMo -- Number of Nodes 0: ", cantidadNodoNivel0.ToString()));
                    ajedrez_sw1.WriteLine(string.Concat("CoMo -- Number of Nodes 1: ", cantidadNodoNivel1.ToString()));
                    ajedrez_sw1.WriteLine(string.Concat("CoMo -- Number of Nodes 2: ", cantidadNodoNivel2.ToString()));


                    for (i = 0; i <= 7; i++)
                    {
                        for (j = 0; j <= 7; j++)
                        {
                            switch (Skakiera_Thinking_init[(i), (j)])
                            {
                                case "White Rook":
                                    NodesAnalysis0_Chessboard_before[i, j, cantidadNodoNivel0] = "WR";
                                    break;

                                case "White Knight":
                                    NodesAnalysis0_Chessboard_before[i, j, cantidadNodoNivel0] = "WN";
                                    break;

                                case "White Bishop":
                                    NodesAnalysis0_Chessboard_before[i, j, cantidadNodoNivel0] = "WB";
                                    break;

                                case "White Queen":
                                    NodesAnalysis0_Chessboard_before[i, j, cantidadNodoNivel0] = "WQ";
                                    break;

                                case "White King":
                                    NodesAnalysis0_Chessboard_before[i, j, cantidadNodoNivel0] = "WK";
                                    break;

                                case "White Pawn":
                                    NodesAnalysis0_Chessboard_before[i, j, cantidadNodoNivel0] = "WP";
                                    break;

                                case "Black Rook":
                                    NodesAnalysis0_Chessboard_before[i, j, cantidadNodoNivel0] = "BR";
                                    break;

                                case "Black Knight":
                                    NodesAnalysis0_Chessboard_before[i, j, cantidadNodoNivel0] = "BN";
                                    break;

                                case "Black Bishop":
                                    NodesAnalysis0_Chessboard_before[i, j, cantidadNodoNivel0] = "BB";
                                    break;

                                case "Black Queen":
                                    NodesAnalysis0_Chessboard_before[i, j, cantidadNodoNivel0] = "BQ";
                                    break;

                                case "Black King":
                                    NodesAnalysis0_Chessboard_before[i, j, cantidadNodoNivel0] = "BK";
                                    break;

                                case "Black Pawn":
                                    NodesAnalysis0_Chessboard_before[i, j, cantidadNodoNivel0] = "BP";
                                    break;

                                case "":
                                    NodesAnalysis0_Chessboard_before[i, j, cantidadNodoNivel0] = "  ";
                                    break;
                            }
                        }
                    }

                    ajedrez_sw1.WriteLine("");
                    ajedrez_sw1.WriteLine("CHESSBOARD Computer Move (upon calling function)");
                    ajedrez_sw1.WriteLine("-----------------------------------------");
                    for (int yj = 7; yj >= 0; yj--)
                    {
                        ajedrez_sw1.WriteLine(String.Concat("| ", NodesAnalysis0_Chessboard_before[0, yj, cantidadNodoNivel0], " | ", NodesAnalysis0_Chessboard_before[1, yj, cantidadNodoNivel0], " | ", NodesAnalysis0_Chessboard_before[2, yj, cantidadNodoNivel0], " | ", NodesAnalysis0_Chessboard_before[3, yj, cantidadNodoNivel0], " | ", NodesAnalysis0_Chessboard_before[4, yj, cantidadNodoNivel0], " | ", NodesAnalysis0_Chessboard_before[5, yj, cantidadNodoNivel0], " | ", NodesAnalysis0_Chessboard_before[6, yj, cantidadNodoNivel0], " | ", NodesAnalysis0_Chessboard_before[7, yj, cantidadNodoNivel0], " |"));
                        ajedrez_sw1.WriteLine("-----------------------------------------");
                    }
                    ajedrez_sw1.WriteLine("CHESSBOARD END");
                }
                #endregion WriteLog


                #region Initialize

                int iii = 0;
                int jjj = 0;
                temporalPuntajeJugador0 = 0;
                temporalPuntajeMovimiento1Jugador = 0;
                temporalPuntajeMovimiento2 = 0;
                jugadorUltimoMovimientoColumn = 0;
                jugadorUltimoMovimientoRow = 0;
                piezaMoviendose = "";
                ProsorinoKommati = "";
                exit_elegxos_nomimothtas = false;
                First_Call = true;
                h = 0;
                p = 0;
                ColumnaReyBlanca = 0;
                RankingReyBlanco = 0;
                BlKingColumn = 0;
                BlKingRank = 0;
                peligroArriba = false;
                m_OrthotitaKinisis = false;
                m_NomimotitaKinisis = false;
                i = 0;
                j = 0;
                puntuacionMovimientoActual = 0;
                mejorMovimientoFinalizarColumnNumer = 0;
                mejorMovimientoRankFinalizar = 0;
                mejorMovimientoNumeroColumna = 0;
                mejorMovimientoRankingInicial = 0;
                detenerAnalisis = true;
                m_StartingColumnNumber_HY = 0;
                m_StartingRank_HY = 0;
                m_FinishingColumnNumber_HY = 0;
                m_FinishingRank_HY = 0;
                enpassant_possible_target_column = 0;
                Best_Variant_text = "";
                posibleComerAtras = false;
                puedeComer = false;
                Mate_Found = false;
                PatEncontrado = false;
                m_ColumnaNumeroInicial_mate = 0;
                m_ColumnaNumeroFinal_mate = 0;
                m_RankingInicial_mate = 0;
                m_RankFinal_mate = 0;

                #region InitializeNodes
                cantidadNodoNivel0 = 0;
                cantidadNodoNivel1 = 0;
                cantidadNodoNivel2 = 0;
                cantidadNodoNivel3 = 0;
                cantidadNodoNivel4 = 0;
                totalNodos = 0;

                valorPiezaMovidaHumano = 0;
                valorPiezaMoviendose = 0;

                for (int dimension1 = 0; dimension1 < 1000000; dimension1++)
                {
                    for (int dimension2 = 0; dimension2 < 6; dimension2++)
                    {
                        analisisNodo0[dimension1, dimension2] = 0;
                    }
                }

                for (int dimension1 = 0; dimension1 < 1000000; dimension1++)
                {
                    for (int dimension2 = 0; dimension2 < 2; dimension2++)
                    {
                        analisisNodo1[dimension1, dimension2] = 0;
                        analisisNodo2[dimension1, dimension2] = 0;
                    }
                }

                for (int dimension1 = 0; dimension1 < 10000000; dimension1++)
                {
                    for (int dimension2 = 0; dimension2 < 2; dimension2++)
                    {
                        analisisNodo03[dimension1, dimension2] = 0;

                    }
                }

                for (int dimension1 = 0; dimension1 < 10000000; dimension1++)
                {
                    for (int dimension2 = 0; dimension2 < 2; dimension2++)
                    {
                        analisisNodo4[dimension1, dimension2] = 0;
                    }
                }


                for (int dimension1 = 0; dimension1 < 1000000; dimension1++)
                {
                    Analisis0Nodo_Text[dimension1] = "";
                    Analisis1Nodo_Text[dimension1] = "";
                    Analisis2Nodo_Text[dimension1] = "";
                }


                for (int dimension1 = 0; dimension1 < 100000; dimension1++)
                {
                    Analisis3Nodo_Text[dimension1] = "";
                    Analisis4Nodo_Text[dimension1] = "";
                }

                #endregion InitializeNodes

                #endregion Initialize



                #region StoreInitialPosition

                for (iii = 0; iii <= 7; iii++)
                {
                    for (jjj = 0; jjj <= 7; jjj++)
                    {
                        Skakiera_Thinking[iii, jjj] = Skakiera_Thinking_init[(iii), (jjj)];
                        Skakiera_Move_0[(iii), (jjj)] = Skakiera_Thinking_init[(iii), (jjj)];
                    }
                }
                #endregion StoreInitialPosition

                int op_iii;
                int op_jjj;
                bool foundOpening;

                int opening = 1;
                foundOpening = false;

                bool exit_opening_loop = false;
                bool match_found;

                String line_in_opening_book;

                do
                {
                    if (File.Exists(String.Concat("Huo Chess Opening Book\\", opening.ToString(), ".txt")))
                    {

                        StreamReader sr = new StreamReader(String.Concat("Huo Chess Opening Book\\", opening.ToString(), ".txt"));
                        match_found = true;

                        for (op_iii = 0; op_iii <= 7; op_iii++)
                        {
                            for (op_jjj = 0; op_jjj <= 7; op_jjj++)
                            {
                                line_in_opening_book = sr.ReadLine();


                                if (Skakiera_Thinking[op_iii, op_jjj].CompareTo(line_in_opening_book) != 0)
                                {
                                    match_found = false;
                                }
                            }
                        }


                        if (match_found == true)
                        {

                            exit_opening_loop = true;


                            detenerAnalisis = true;

                            line_in_opening_book = sr.ReadLine();

                            line_in_opening_book = sr.ReadLine();
                            mejorMovimientoNumeroColumna = Int32.Parse(line_in_opening_book);
                            line_in_opening_book = sr.ReadLine();
                            mejorMovimientoRankingInicial = Int32.Parse(line_in_opening_book);

                            line_in_opening_book = sr.ReadLine();
                            mejorMovimientoFinalizarColumnNumer = Int32.Parse(line_in_opening_book);
                            line_in_opening_book = sr.ReadLine();
                            mejorMovimientoRankFinalizar = Int32.Parse(line_in_opening_book);

                            foundOpening = true;
                        }
                    }
                    else
                    {
                        exit_opening_loop = true;
                    }

                    opening = opening + 1;
                } while (exit_opening_loop == false);


                #region DangerousSquares
                piezaEnPeligro = false;

                for (int o1 = 0; o1 <= 7; o1++)
                {
                    for (int p1 = 0; p1 <= 7; p1++)
                    {
                        Skakiera_cuadros_peligro[(o1), (p1)] = 0;
                        valorDefensores[(o1), (p1)] = 0;
                        valorAtacantes[(o1), (p1)] = 0;
                        numeroDefensores[(o1), (p1)] = 0;
                        numeroAtacantes[(o1), (p1)] = 0;
                    }
                }

                EncontrarAtacantes(Skakiera_Thinking);
                EncontrarDefensores(Skakiera_Thinking);

                for (int o1 = 0; o1 <= 7; o1++)
                {
                    for (int p1 = 0; p1 <= 7; p1++)
                    {

                        if (numeroAtacantes[o1, p1] > numeroDefensores[o1, p1])

                            Skakiera_cuadros_peligro[(o1), (p1)] = 1;
                    }
                }

                #region WriteLog
                if (activateLogs == true)
                {

                    for (i = 0; i <= 7; i++)
                    {
                        for (j = 0; j <= 7; j++)
                        {
                            switch (Skakiera_Thinking_init[(i), (j)])
                            {
                                case "White Rook":
                                    SkakieraLog[i, j] = "WR";
                                    break;

                                case "White Knight":
                                    SkakieraLog[i, j] = "WN";
                                    break;

                                case "White Bishop":
                                    SkakieraLog[i, j] = "WB";
                                    break;

                                case "White Queen":
                                    SkakieraLog[i, j] = "WQ";
                                    break;

                                case "White King":
                                    SkakieraLog[i, j] = "WK";
                                    break;

                                case "White Pawn":
                                    SkakieraLog[i, j] = "WP";
                                    break;

                                case "Black Rook":
                                    SkakieraLog[i, j] = "BR";
                                    break;

                                case "Black Knight":
                                    SkakieraLog[i, j] = "BN";
                                    break;

                                case "Black Bishop":
                                    SkakieraLog[i, j] = "BB";
                                    break;

                                case "Black Queen":
                                    SkakieraLog[i, j] = "BQ";
                                    break;

                                case "Black King":
                                    SkakieraLog[i, j] = "BK";
                                    break;

                                case "Black Pawn":
                                    SkakieraLog[i, j] = "BP";
                                    break;

                                case "":
                                    SkakieraLog[i, j] = "  ";
                                    break;
                            }
                        }
                    }

                    ajedrez_sw_attackers.WriteLine("CHESSBOARD");
                    ajedrez_sw_attackers.WriteLine("-----------------------------------------");
                    for (int yj = 7; yj >= 0; yj--)
                    {
                        ajedrez_sw_attackers.WriteLine(String.Concat("| ", SkakieraLog[0, yj], " | ", SkakieraLog[1, yj], " | ", SkakieraLog[2, yj], " | ", SkakieraLog[3, yj], " | ", SkakieraLog[4, yj], " | ", SkakieraLog[5, yj], " | ", SkakieraLog[6, yj], " | ", SkakieraLog[7, yj], " |"));
                        ajedrez_sw_attackers.WriteLine("-----------------------------------------");
                    }

                    ajedrez_sw_attackers.WriteLine("");
                    ajedrez_sw_attackers.WriteLine("");

                    ajedrez_sw_attackers.WriteLine("CHESSBOARD: Number of attackers");
                    ajedrez_sw_attackers.WriteLine(String.Concat("Move = ", movimeinto.ToString()));
                    ajedrez_sw_attackers.WriteLine("-----------------------------------------");
                    for (int yj = 7; yj >= 0; yj--)
                    {
                        ajedrez_sw_attackers.WriteLine(String.Concat("| ", numeroAtacantes[0, yj], " | ", numeroAtacantes[1, yj], " | ", numeroAtacantes[2, yj], " | ", numeroAtacantes[3, yj], " | ", numeroAtacantes[4, yj], " | ", numeroAtacantes[5, yj], " | ", numeroAtacantes[6, yj], " | ", numeroAtacantes[7, yj], " |"));
                        ajedrez_sw_attackers.WriteLine("-----------------------------------------");
                    }

                    ajedrez_sw_attackers.WriteLine("");
                    ajedrez_sw_attackers.WriteLine("");

                    ajedrez_sw_attackers.WriteLine("CHESSBOARD: Value of attackers");
                    ajedrez_sw_attackers.WriteLine("-----------------------------------------");
                    for (int yj = 7; yj >= 0; yj--)
                    {
                        ajedrez_sw_attackers.WriteLine(String.Concat("| ", valorAtacantes[0, yj], " | ", valorAtacantes[1, yj], " | ", valorAtacantes[2, yj], " | ", valorAtacantes[3, yj], " | ", valorAtacantes[4, yj], " | ", valorAtacantes[5, yj], " | ", valorAtacantes[6, yj], " | ", valorAtacantes[7, yj], " |"));
                        ajedrez_sw_attackers.WriteLine("-----------------------------------------");
                    }

                    ajedrez_sw_attackers.WriteLine("");
                    ajedrez_sw_attackers.WriteLine("");

                    ajedrez_sw_attackers.WriteLine("CHESSBOARD: Number of defenders");
                    ajedrez_sw_attackers.WriteLine(String.Concat("Move = ", movimeinto.ToString()));
                    ajedrez_sw_attackers.WriteLine("-----------------------------------------");
                    for (int yj = 7; yj >= 0; yj--)
                    {
                        ajedrez_sw_attackers.WriteLine(String.Concat("| ", numeroDefensores[0, yj], " | ", numeroDefensores[1, yj], " | ", numeroDefensores[2, yj], " | ", numeroDefensores[3, yj], " | ", numeroDefensores[4, yj], " | ", numeroDefensores[5, yj], " | ", numeroDefensores[6, yj], " | ", numeroDefensores[7, yj], " |"));
                        ajedrez_sw_attackers.WriteLine("-----------------------------------------");
                    }

                    ajedrez_sw_attackers.WriteLine("");
                    ajedrez_sw_attackers.WriteLine("");

                    ajedrez_sw_attackers.WriteLine("CHESSBOARD: Value of defenders");
                    ajedrez_sw_attackers.WriteLine("-----------------------------------------");
                    for (int yj = 7; yj >= 0; yj--)
                    {
                        ajedrez_sw_attackers.WriteLine(String.Concat("| ", valorDefensores[0, yj], " | ", valorDefensores[1, yj], " | ", valorDefensores[2, yj], " | ", valorDefensores[3, yj], " | ", valorDefensores[4, yj], " | ", valorDefensores[5, yj], " | ", valorDefensores[6, yj], " | ", valorDefensores[7, yj], " |"));
                        ajedrez_sw_attackers.WriteLine("-----------------------------------------");
                    }

                    ajedrez_sw_attackers.WriteLine("");
                    ajedrez_sw_attackers.WriteLine("");

                    ajedrez_sw_attackers.WriteLine("CHESSBOARD: Dangerous squares");
                    ajedrez_sw_attackers.WriteLine("-----------------------------------------");
                    for (int yj = 7; yj >= 0; yj--)
                    {
                        ajedrez_sw_attackers.WriteLine(String.Concat("| ", Skakiera_cuadros_peligro[0, yj], " | ", Skakiera_cuadros_peligro[1, yj], " | ", Skakiera_cuadros_peligro[2, yj], " | ", Skakiera_cuadros_peligro[3, yj], " | ", Skakiera_cuadros_peligro[4, yj], " | ", Skakiera_cuadros_peligro[5, yj], " | ", Skakiera_cuadros_peligro[6, yj], " | ", Skakiera_cuadros_peligro[7, yj], " |"));
                        ajedrez_sw_attackers.WriteLine("-----------------------------------------");
                    }
                }
                #endregion WriteLog

                #endregion DangerousSquares

                #region checkForCheck
                checado = false;

                if (mColorJugsdor.CompareTo("White") == 0)
                    checado = ChequeoNegro(Skakiera_Thinking);
                else if (mColorJugsdor.CompareTo("Black") == 0)
                    checado = ChequeoNegro(Skakiera_Thinking);
                #endregion checkForCheck

                if (foundOpening == false)
                {
                    #region checkAllMoves
                    for (iii = 0; iii <= 7; iii++)
                    {
                        for (jjj = 0; jjj <= 7; jjj++)
                        {
                            if (((quienEStaAnalizado.CompareTo("HY") == 0) && ((((Skakiera_Thinking[(iii), (jjj)].CompareTo("White King") == 0) || (Skakiera_Thinking[(iii), (jjj)].CompareTo("White Queen") == 0) || (Skakiera_Thinking[(iii), (jjj)].CompareTo("White Rook") == 0) || (Skakiera_Thinking[(iii), (jjj)].CompareTo("White Knight") == 0) || (Skakiera_Thinking[(iii), (jjj)].CompareTo("White Bishop") == 0) || (Skakiera_Thinking[(iii), (jjj)].CompareTo("White Pawn") == 0)) && (mColorJugsdor.CompareTo("Black") == 0)) || (((Skakiera_Thinking[(iii), (jjj)].CompareTo("Black King") == 0) || (Skakiera_Thinking[(iii), (jjj)].CompareTo("Black Queen") == 0) || (Skakiera_Thinking[(iii), (jjj)].CompareTo("Black Rook") == 0) || (Skakiera_Thinking[(iii), (jjj)].CompareTo("Black Knight") == 0) || (Skakiera_Thinking[(iii), (jjj)].CompareTo("Black Bishop") == 0) || (Skakiera_Thinking[(iii), (jjj)].CompareTo("Black Pawn") == 0)) && (mColorJugsdor.CompareTo("White") == 0)))) || ((quienEStaAnalizado.CompareTo("Hu") == 0) && ((((Skakiera_Thinking[(iii), (jjj)].CompareTo("White King") == 0) || (Skakiera_Thinking[(iii), (jjj)].CompareTo("White Queen") == 0) || (Skakiera_Thinking[(iii), (jjj)].CompareTo("White Rook") == 0) || (Skakiera_Thinking[(iii), (jjj)].CompareTo("White Knight") == 0) || (Skakiera_Thinking[(iii), (jjj)].CompareTo("White Bishop") == 0) || (Skakiera_Thinking[(iii), (jjj)].CompareTo("White Pawn") == 0)) && (mColorJugsdor.CompareTo("White") == 0)) || (((Skakiera_Thinking[(iii), (jjj)].CompareTo("Black King") == 0) || (Skakiera_Thinking[(iii), (jjj)].CompareTo("Black Queen") == 0) || (Skakiera_Thinking[(iii), (jjj)].CompareTo("Black Rook") == 0) || (Skakiera_Thinking[(iii), (jjj)].CompareTo("Black Knight") == 0) || (Skakiera_Thinking[(iii), (jjj)].CompareTo("Black Bishop") == 0) || (Skakiera_Thinking[(iii), (jjj)].CompareTo("Black Pawn") == 0)) && (mColorJugsdor.CompareTo("Black") == 0)))))
                            {

                                for (int w = 0; w <= 7; w++)
                                {
                                    for (int r = 0; r <= 7; r++)
                                    {
                                        ProsorinoKommati = "";
                                        valorPiezaMoviendose = 0;
                                        valorPieza = 0;
                                        piezaMoviendose = Skakiera_Thinking[(iii), (jjj)];
                                        numeroColumnaInicial = iii + 1;
                                        columnaFinaliza = w + 1;
                                        m_StartingRank = jjj + 1;
                                        m_FinishingRank = r + 1;
                                        ProsorinoKommati = Skakiera_Thinking[(columnaFinaliza - 1), (m_FinishingRank - 1)];


                                        movimientoInutil = "N";
                                        if (movimeinto < 5)
                                        {

                                            if ((piezaMoviendose.CompareTo("White Pawn") == 0) && ((numeroColumnaInicial == 1) || (numeroColumnaInicial == 2)))
                                            {
                                                movimientoInutil = "Y";
                                            }
                                            else if ((piezaMoviendose.CompareTo("White Pawn") == 0) && ((numeroColumnaInicial == 7) || (numeroColumnaInicial == 8)))
                                            {
                                                movimientoInutil = "Y";
                                            }
                                            else if ((piezaMoviendose.CompareTo("Black Pawn") == 0) && ((numeroColumnaInicial == 1) || (numeroColumnaInicial == 2)))
                                            {
                                                movimientoInutil = "Y";
                                            }
                                            else if ((piezaMoviendose.CompareTo("Black Pawn") == 0) && ((numeroColumnaInicial == 7) || (numeroColumnaInicial == 8)))
                                            {
                                                movimientoInutil = "Y";
                                            }
                                            // Do not move the 'f' pawns!
                                            else if ((piezaMoviendose.CompareTo("White Pawn") == 0) && ((numeroColumnaInicial == 6) && (m_StartingRank == 2)))
                                            {
                                                movimientoInutil = "Y";
                                            }
                                            else if ((piezaMoviendose.CompareTo("Black Pawn") == 0) && ((numeroColumnaInicial == 6) && (m_StartingRank == 7)))
                                            {
                                                movimientoInutil = "Y";
                                            }
                                            else if ((piezaMoviendose.CompareTo("White King") == 0) || (piezaMoviendose.CompareTo("Black King") == 0))
                                            {
                                                movimientoInutil = "Y";
                                            }

                                        }


                                        if ((piezaMoviendose.CompareTo("White Rook") == 0) || (piezaMoviendose.CompareTo("Black Rook") == 0))
                                            valorPiezaMoviendose = 5;
                                        if ((piezaMoviendose.CompareTo("White Knight") == 0) || (piezaMoviendose.CompareTo("Black Knight") == 0))
                                            valorPiezaMoviendose = 3;
                                        if ((piezaMoviendose.CompareTo("White Bishop") == 0) || (piezaMoviendose.CompareTo("Black Bishop") == 0))
                                            valorPiezaMoviendose = 3;
                                        if ((piezaMoviendose.CompareTo("White Queen") == 0) || (piezaMoviendose.CompareTo("Black Queen") == 0))
                                            valorPiezaMoviendose = 9;
                                        if ((piezaMoviendose.CompareTo("White King") == 0) || (piezaMoviendose.CompareTo("Black King") == 0))
                                            valorPiezaMoviendose = 119;
                                        if ((piezaMoviendose.CompareTo("White Pawn") == 0) || (piezaMoviendose.CompareTo("Black Pawn") == 0))
                                            valorPiezaMoviendose = 1;

                                        if ((ProsorinoKommati.CompareTo("White Rook") == 0) || (ProsorinoKommati.CompareTo("Black Rook") == 0))
                                            valorPieza = 5;
                                        if ((ProsorinoKommati.CompareTo("White Knight") == 0) || (ProsorinoKommati.CompareTo("Black Knight") == 0))
                                            valorPieza = 3;
                                        if ((ProsorinoKommati.CompareTo("White Bishop") == 0) || (ProsorinoKommati.CompareTo("Black Bishop") == 0))
                                            valorPieza = 3;
                                        if ((ProsorinoKommati.CompareTo("White Queen") == 0) || (ProsorinoKommati.CompareTo("Black Queen") == 0))
                                            valorPieza = 9;
                                        if ((ProsorinoKommati.CompareTo("White King") == 0) || (ProsorinoKommati.CompareTo("Black King") == 0))
                                            valorPieza = 119;
                                        if ((ProsorinoKommati.CompareTo("White Pawn") == 0) || (ProsorinoKommati.CompareTo("Black Pawn") == 0))
                                            valorPieza = 1;


                                        #endregion findValueOfPieces



                                        if ((numeroAtacantes[(columnaFinaliza - 1), (m_FinishingRank - 1)] >= 1) && (valorAtacantes[(columnaFinaliza - 1), (m_FinishingRank - 1)] < valorPiezaMoviendose))
                                        {
                                            movimientoInutil = "Y";
                                        }

                                        movimientoPeligroso = false;

                                        if ((Skakiera_cuadros_peligro[(columnaFinaliza - 1), (m_FinishingRank - 1)] != 0))
                                        {
                                            movimientoPeligroso = true;
                                        }



                                        if (1 == 1)
                                        {

                                            checarMovimiento(Skakiera_Thinking, m_StartingRank, numeroColumnaInicial, m_FinishingRank, columnaFinaliza, piezaMoviendose);
                                            if (((m_OrthotitaKinisis == true) && (m_NomimotitaKinisis == true)) && (movimientoAnalizado == 0))
                                            {

                                                moviendoPieza_HY = piezaMoviendose;
                                                m_StartingColumnNumber_HY = numeroColumnaInicial;
                                                m_FinishingColumnNumber_HY = columnaFinaliza;
                                                m_StartingRank_HY = m_StartingRank;
                                                m_FinishingRank_HY = m_FinishingRank;
                                                analisisNodo0[cantidadNodoNivel0, 2] = m_StartingColumnNumber_HY;
                                                analisisNodo0[cantidadNodoNivel0, 3] = m_FinishingColumnNumber_HY;
                                                analisisNodo0[cantidadNodoNivel0, 4] = m_StartingRank_HY;
                                                analisisNodo0[cantidadNodoNivel0, 5] = m_FinishingRank_HY;

                                                mejorMovimientoEncontrado = true;
                                            }



                                            if ((m_OrthotitaKinisis == true) && (m_NomimotitaKinisis == true))
                                            {

                                                String m_StartingColumnNumber_moveText;
                                                String m_FinishingColumnNumber_moveText;

                                                switch (numeroColumnaInicial)
                                                {
                                                    case (1):
                                                        m_StartingColumnNumber_moveText = "a";
                                                        break;

                                                    case (2):
                                                        m_StartingColumnNumber_moveText = "b";
                                                        break;

                                                    case (3):
                                                        m_StartingColumnNumber_moveText = "c";
                                                        break;

                                                    case (4):
                                                        m_StartingColumnNumber_moveText = "d";
                                                        break;

                                                    case (5):
                                                        m_StartingColumnNumber_moveText = "e";
                                                        break;

                                                    case (6):
                                                        m_StartingColumnNumber_moveText = "f";
                                                        break;

                                                    case (7):
                                                        m_StartingColumnNumber_moveText = "g";
                                                        break;

                                                    case (8):
                                                        m_StartingColumnNumber_moveText = "h";
                                                        break;

                                                    default:
                                                        m_StartingColumnNumber_moveText = "Error";
                                                        break;
                                                }

                                                switch (columnaFinaliza)
                                                {
                                                    case (1):
                                                        m_FinishingColumnNumber_moveText = "a";
                                                        break;

                                                    case (2):
                                                        m_FinishingColumnNumber_moveText = "b";
                                                        break;

                                                    case (3):
                                                        m_FinishingColumnNumber_moveText = "c";
                                                        break;

                                                    case (4):
                                                        m_FinishingColumnNumber_moveText = "d";
                                                        break;

                                                    case (5):
                                                        m_FinishingColumnNumber_moveText = "e";
                                                        break;

                                                    case (6):
                                                        m_FinishingColumnNumber_moveText = "f";
                                                        break;

                                                    case (7):
                                                        m_FinishingColumnNumber_moveText = "g";
                                                        break;

                                                    case (8):
                                                        m_FinishingColumnNumber_moveText = "h";
                                                        break;

                                                    default:
                                                        m_FinishingColumnNumber_moveText = "Error";
                                                        break;
                                                }

                                                Movimiento0 = String.Concat(m_StartingColumnNumber_moveText,
                                                                           m_StartingRank.ToString(), " -> ",
                                                                           m_FinishingColumnNumber_moveText,
                                                                           m_FinishingRank.ToString());

                                                Analisis0Nodo_Text[cantidadNodoNivel0] = Movimiento0;


                                                Skakiera_Thinking[(numeroColumnaInicial - 1), (m_StartingRank - 1)] = "";
                                                Skakiera_Thinking[(columnaFinaliza - 1), (m_FinishingRank - 1)] = piezaMoviendose;




                                                temporalPuntajeJugador0 = contarPuntaje(Skakiera_Thinking);


                                                analisisNodo0[cantidadNodoNivel0, 0] = temporalPuntajeJugador0;
                                                analisisNodo0[cantidadNodoNivel0, 1] = 0;





                                                if (valorPiezaMoviendose < valorPieza)
                                                {
                                                    mejorMovimientoNumeroColumna = numeroColumnaInicial;
                                                    mejorMovimientoRankingInicial = m_StartingRank;
                                                    mejorMovimientoFinalizarColumnNumer = columnaFinaliza;
                                                    mejorMovimientoRankFinalizar = m_FinishingRank;
                                                    puedeComer = true;
                                                }




                                                if ((columnaFinaliza == jugadorUltimoMovimientoColumn)
                                                     && (m_FinishingRank == jugadorUltimoMovimientoRow)
                                                     && (valorPiezaMoviendose <= valorPiezaMovidaHumano))
                                                {
                                                    mejorMovimientoNumeroColumna = numeroColumnaInicial;
                                                    mejorMovimientoRankingInicial = m_StartingRank;
                                                    mejorMovimientoFinalizarColumnNumer = columnaFinaliza;
                                                    mejorMovimientoRankFinalizar = m_FinishingRank;
                                                    posibleComerAtras = true;
                                                }


                                                if ((movimientoAnalizado < revisarProfundo) && (posibleComerAtras == false))
                                                {
                                                    movimientoAnalizado = movimientoAnalizado + 1;

                                                    String[,] Skakiera_Move_After_0_new = new String[8, 8];

                                                    for (i = 0; i <= 7; i++)
                                                    {
                                                        for (j = 0; j <= 7; j++)
                                                        {
                                                            Skakiera_Move_After_0_new[(i), (j)] = Skakiera_Thinking[(i), (j)];
                                                        }
                                                    }

                                                    quienEStaAnalizado = "Human";
                                                    if (mColorJugsdor.CompareTo("Black") == 0)
                                                        colorJugando = "Black";
                                                    else if (mColorJugsdor.CompareTo("White") == 0)
                                                        colorJugando = "White";

                                                    Analizar1MovimientoHumano(Skakiera_Move_After_0_new);
                                                    if (mColorJugsdor.CompareTo("Black") == 0)
                                                        colorJugando = "White";
                                                    else if (mColorJugsdor.CompareTo("White") == 0)
                                                        colorJugando = "Black";

                                                }

                                                Skakiera_Thinking[(numeroColumnaInicial - 1), (m_StartingRank - 1)] = piezaMoviendose;
                                                Skakiera_Thinking[(columnaFinaliza - 1), (m_FinishingRank - 1)] = ProsorinoKommati;

                                                if (PatEncontrado == true)
                                                {
                                                    analisisNodo0[cantidadNodoNivel0, 0] = 0;
                                                    PatEncontrado = false;
                                                }

                                                cantidadNodoNivel0++;
                                            }

                                        }

                                        if ((checado == true) && (mejorMovimientoEncontrado == false))
                                        {

                                            MessageBox.Show("Checkmate!");

                                        }
                                        if (activateLogs == true)
                                        {
                                            StreamWriter huo_sw4 = new StreamWriter("HUO_CHESS_LOG_Minmax_Before.txt", true);

                                            //V0.990 test: Add a log
                                            huo_sw4.WriteLine("");
                                            huo_sw4.WriteLine("----------- BEFORE ---------");

                                            // v0.992
                                            huo_sw4.WriteLine("");
                                            huo_sw4.WriteLine("-------------- Level 4 Nodes (3rd computer move) -------------");
                                            huo_sw4.WriteLine("");
                                            for (int lala = 0; lala < cantidadNodoNivel4; lala++)
                                            {
                                                huo_sw4.WriteLine(String.Concat("NodeLevel4[", lala.ToString(), "] (Score)  = ", analisisNodo4[lala, 0].ToString(), " [Parent = ", analisisNodo4[lala, 1].ToString(), "]"));
                                                huo_sw4.WriteLine(String.Concat("Variant in the node: ", Analisis4Nodo_Text[lala]));
                                                huo_sw4.WriteLine("");
                                                huo_sw4.WriteLine("");
                                            }

                                            // v0.992
                                            huo_sw4.WriteLine("");
                                            huo_sw4.WriteLine("-------------- Level 3 Nodes (2nd human move) -------------");
                                            huo_sw4.WriteLine("");
                                            for (int lala = 0; lala < cantidadNodoNivel3; lala++)
                                            {
                                                huo_sw4.WriteLine(String.Concat("NodeLevel3[", lala.ToString(), "] (Score)  = ", analisisNodo03[lala, 0].ToString(), " [Parent = ", analisisNodo03[lala, 1].ToString(), "]"));
                                                huo_sw4.WriteLine(String.Concat("Variant in the node: ", Analisis3Nodo_Text[lala]));
                                                huo_sw4.WriteLine("");
                                                huo_sw4.WriteLine("");
                                            }

                                            // v0.992: Start counting from 0 until < NodeLevel_2_count! (applies to all, in the Before and After logs!)
                                            huo_sw4.WriteLine("");
                                            huo_sw4.WriteLine("-------------- Level 2 Nodes (2nd computer move) -------------");
                                            huo_sw4.WriteLine("");
                                            for (int lala = 0; lala < cantidadNodoNivel2; lala++)
                                            {
                                                huo_sw4.WriteLine(String.Concat("NodeLevel2[", lala.ToString(), "] (Score)  = ", analisisNodo2[lala, 0].ToString(), " [Parent = ", analisisNodo2[lala, 1].ToString(), "]"));
                                                huo_sw4.WriteLine(String.Concat("Variant in the node: ", Analisis2Nodo_Text[lala]));
                                                huo_sw4.WriteLine("");
                                                huo_sw4.WriteLine("");
                                            }

                                            huo_sw4.WriteLine("");
                                            huo_sw4.WriteLine("-------------- Level 1 Nodes (1st human response) -------------");
                                            huo_sw4.WriteLine("");
                                            for (int lala = 0; lala < cantidadNodoNivel1; lala++)
                                            {
                                                huo_sw4.WriteLine(String.Concat("NodeLevel1[", lala.ToString(), "] (Score)  = ", analisisNodo1[lala, 0].ToString(), " [Parent = ", analisisNodo1[lala, 1].ToString(), "]"));
                                                huo_sw4.WriteLine(String.Concat("Variant in the node: ", Analisis1Nodo_Text[lala]));
                                                huo_sw4.WriteLine("");

                                            }

                                            huo_sw4.WriteLine("");
                                            huo_sw4.WriteLine("-------------- Level 0 Nodes (initial computer move) -------------");
                                            huo_sw4.WriteLine("");
                                            for (int lala = 0; lala < cantidadNodoNivel0; lala++)
                                            {
                                                huo_sw4.WriteLine(String.Concat("NodeLevel0[", lala.ToString(), "] (Score)  = ", analisisNodo0[lala, 0].ToString(), " [Parent = ", analisisNodo0[lala, 1].ToString(), "]"));
                                                huo_sw4.WriteLine(String.Concat("Variant in the node: ", Analisis0Nodo_Text[lala]));
                                                huo_sw4.WriteLine("");

                                            }

                                            huo_sw4.Close();
                                        }
                                    }
                                }

                            }


                        }
                    }

                }


                if ((posibleComerAtras == false) && (foundOpening == false))
                {

                    int counter0, counter1, counter2, counter3, counter4;


                    int parentNodeAnalyzed = -999;

                    if (revisarProfundo == 4)
                    {
                        for (counter4 = 0; counter4 < cantidadNodoNivel4; counter4++)
                        {
                            if (Int32.Parse(analisisNodo4[counter4, 1].ToString()) != parentNodeAnalyzed)
                            {
                                parentNodeAnalyzed = Int32.Parse(analisisNodo4[counter4, 1].ToString());
                                analisisNodo03[Int32.Parse(analisisNodo4[counter4, 1].ToString()), 0] = analisisNodo4[counter4, 0];
                                mejorSeleecion3 = counter4;
                                mejoresNodos4[parentNodeAnalyzed] = counter4;
                            }

                            if (mColorJugsdor.CompareTo("White") == 0)
                            {
                                if (analisisNodo4[counter4, 0] <= analisisNodo03[Int32.Parse(analisisNodo4[counter4, 1].ToString()), 0])
                                {
                                    analisisNodo03[Int32.Parse(analisisNodo4[counter4, 1].ToString()), 0] = analisisNodo4[counter4, 0];
                                    mejorSeleecion3 = counter4;
                                    mejoresNodos4[parentNodeAnalyzed] = counter4;
                                }
                            }
                            else if (mColorJugsdor.CompareTo("Black") == 0)
                            {
                                if (analisisNodo4[counter4, 0] >= analisisNodo03[Int32.Parse(analisisNodo4[counter4, 1].ToString()), 0])
                                {
                                    analisisNodo03[Int32.Parse(analisisNodo4[counter4, 1].ToString()), 0] = analisisNodo4[counter4, 0];
                                    mejorSeleecion3 = counter4;
                                    mejoresNodos4[parentNodeAnalyzed] = counter4;
                                }
                            }
                        }

                        for (counter3 = 0; counter3 < cantidadNodoNivel3; counter3++)
                        {
                            if (Int32.Parse(analisisNodo03[counter3, 1].ToString()) != parentNodeAnalyzed)
                            {
                                parentNodeAnalyzed = Int32.Parse(analisisNodo03[counter3, 1].ToString());
                                analisisNodo2[Int32.Parse(analisisNodo03[counter3, 1].ToString()), 0] = analisisNodo03[counter3, 0];
                                mejorSeleecion3 = counter3;
                                mejoresNodos3[parentNodeAnalyzed] = counter3;
                            }

                            if (mColorJugsdor.CompareTo("White") == 0)
                            {
                                if (analisisNodo03[counter3, 0] >= analisisNodo2[Int32.Parse(analisisNodo03[counter3, 1].ToString()), 0])
                                {
                                    analisisNodo2[Int32.Parse(analisisNodo03[counter3, 1].ToString()), 0] = analisisNodo03[counter3, 0];
                                    mejorSeleecion3 = counter3;
                                    mejoresNodos3[parentNodeAnalyzed] = counter3;
                                }
                            }
                            else if (mColorJugsdor.CompareTo("Black") == 0)
                            {
                                if (analisisNodo03[counter3, 0] <= analisisNodo2[Int32.Parse(analisisNodo03[counter3, 1].ToString()), 0])
                                {
                                    analisisNodo2[Int32.Parse(analisisNodo03[counter3, 1].ToString()), 0] = analisisNodo03[counter3, 0];
                                    mejorSeleecion3 = counter3;
                                    mejoresNodos3[parentNodeAnalyzed] = counter3;
                                }

                            }
                        }

                    }


                    for (counter2 = 0; counter2 < cantidadNodoNivel2; counter2++)
                    {
                        if (Int32.Parse(analisisNodo2[counter2, 1].ToString()) != parentNodeAnalyzed)
                        {

                            parentNodeAnalyzed = Int32.Parse(analisisNodo2[counter2, 1].ToString());
                            analisisNodo1[Int32.Parse(analisisNodo2[counter2, 1].ToString()), 0] = analisisNodo2[counter2, 0];
                            mejorSeleecion2 = counter2;
                            mejoresNodos2[parentNodeAnalyzed] = counter2;
                        }

                        if (mColorJugsdor.CompareTo("White") == 0)
                        {
                            if ((analisisNodo2[counter2, 0] <= analisisNodo1[Int32.Parse(analisisNodo2[counter2, 1].ToString()), 0]))
                            {
                                analisisNodo1[Int32.Parse(analisisNodo2[counter2, 1].ToString()), 0] = analisisNodo2[counter2, 0];
                                mejorSeleecion2 = counter2;
                                mejoresNodos2[parentNodeAnalyzed] = counter2;
                            }
                        }
                        else if (mColorJugsdor.CompareTo("Black") == 0)
                        {
                            if (analisisNodo2[counter2, 0] >= analisisNodo1[Int32.Parse(analisisNodo2[counter2, 1].ToString()), 0])
                            {
                                analisisNodo1[Int32.Parse(analisisNodo2[counter2, 1].ToString()), 0] = analisisNodo2[counter2, 0];
                                mejorSeleecion2 = counter2;
                                mejoresNodos2[parentNodeAnalyzed] = counter2;
                            }
                        }
                    }


                    parentNodeAnalyzed = -999;


                    for (counter1 = 0; counter1 < cantidadNodoNivel1; counter1++)
                    {
                        if (Int32.Parse(analisisNodo1[counter1, 1].ToString()) != parentNodeAnalyzed)
                        {

                            parentNodeAnalyzed = Int32.Parse(analisisNodo1[counter1, 1].ToString());
                            analisisNodo0[Int32.Parse(analisisNodo1[counter1, 1].ToString()), 0] = analisisNodo1[counter1, 0];
                            mejorSeleecion1 = counter1;
                            mejoresNodos1[parentNodeAnalyzed] = counter1;
                        }

                        if (mColorJugsdor.CompareTo("White") == 0)
                        {

                            if (analisisNodo1[counter1, 0] >= analisisNodo0[Int32.Parse(analisisNodo1[counter1, 1].ToString()), 0])
                            {
                                analisisNodo0[Int32.Parse(analisisNodo1[counter1, 1].ToString()), 0] = analisisNodo1[counter1, 0];
                                mejorSeleecion1 = counter1;
                                mejoresNodos1[parentNodeAnalyzed] = counter1;
                            }
                        }
                        else if (mColorJugsdor.CompareTo("Black") == 0)
                        {

                            if (analisisNodo1[counter1, 0] <= analisisNodo0[Int32.Parse(analisisNodo1[counter1, 1].ToString()), 0])
                            {
                                analisisNodo0[Int32.Parse(analisisNodo1[counter1, 1].ToString()), 0] = analisisNodo1[counter1, 0];
                                mejorSeleecion1 = counter1;
                                mejoresNodos1[parentNodeAnalyzed] = counter1;
                            }
                        }
                    }


                    double temp_score = analisisNodo0[0, 0];
                    Best_Variant_text = "";

                    mejorMovimientoNumeroColumna = Int32.Parse(analisisNodo0[0, 2].ToString());
                    mejorMovimientoRankingInicial = Int32.Parse(analisisNodo0[0, 4].ToString());
                    mejorMovimientoFinalizarColumnNumer = Int32.Parse(analisisNodo0[0, 3].ToString());
                    mejorMovimientoRankFinalizar = Int32.Parse(analisisNodo0[0, 5].ToString());

                    mejorSeleecion0 = 0;


                    for (counter0 = 0; counter0 < cantidadNodoNivel0; counter0++)
                    {
                        if ((analisisNodo0[counter0, 3] == mejorMovimientoColumnNumberPrevio) &&
                        (analisisNodo0[counter0, 5] == previoRankMejorMovimiento) &&
                        (piezaMoviendose.CompareTo(piezaMovidaPreviamente) == 0))
                        {
                            if (mColorJugsdor.CompareTo("Black") == 0)
                            {
                                analisisNodo0[counter0, 0] = analisisNodo0[counter0, 0] - 10;
                            }
                            else if (mColorJugsdor.CompareTo("White") == 0)
                            {
                                analisisNodo0[counter0, 0] = analisisNodo0[counter0, 0] + 10;
                            }
                        }

                        if (mColorJugsdor.CompareTo("Black") == 0)
                        {

                            if (analisisNodo0[counter0, 0] > temp_score)

                            {
                                temp_score = analisisNodo0[counter0, 0];

                                mejorMovimientoNumeroColumna = Int32.Parse(analisisNodo0[counter0, 2].ToString());
                                mejorMovimientoRankingInicial = Int32.Parse(analisisNodo0[counter0, 4].ToString());
                                mejorMovimientoFinalizarColumnNumer = Int32.Parse(analisisNodo0[counter0, 3].ToString());
                                mejorMovimientoRankFinalizar = Int32.Parse(analisisNodo0[counter0, 5].ToString());

                                mejorSeleecion0 = counter0;
                            }
                        }
                        else if (mColorJugsdor.CompareTo("White") == 0)
                        {

                            if (analisisNodo0[counter0, 0] < temp_score)

                            {
                                temp_score = analisisNodo0[counter0, 0];

                                mejorMovimientoNumeroColumna = Int32.Parse(analisisNodo0[counter0, 2].ToString());
                                mejorMovimientoRankingInicial = Int32.Parse(analisisNodo0[counter0, 4].ToString());
                                mejorMovimientoFinalizarColumnNumer = Int32.Parse(analisisNodo0[counter0, 3].ToString());
                                mejorMovimientoRankFinalizar = Int32.Parse(analisisNodo0[counter0, 5].ToString());

                                mejorSeleecion0 = counter0;
                            }
                        }
                    }


                    if (Mate_Found == true)
                    {
                        mejorMovimientoNumeroColumna = m_ColumnaNumeroInicial_mate;
                        mejorMovimientoFinalizarColumnNumer = m_ColumnaNumeroFinal_mate;
                        mejorMovimientoRankingInicial = m_RankingInicial_mate;
                        mejorMovimientoRankFinalizar = m_RankFinal_mate;
                    }

                    piezaMovidaPreviamente = piezaMoviendose;
                    mejorMovimientoColumnNumberPrevio = mejorMovimientoNumeroColumna;
                    previoRankMejorMovimiento = mejorMovimientoRankingInicial;


                    Best_Variant_text = String.Concat(
                        Analisis0Nodo_Text[mejorSeleecion0].ToString(), " , ",
                        Analisis1Nodo_Text[mejoresNodos1[mejorSeleecion0]].ToString(), " , ",
                        Analisis2Nodo_Text[mejoresNodos2[mejoresNodos1[mejorSeleecion0]]].ToString(), " , ",
                        Analisis3Nodo_Text[mejoresNodos3[mejoresNodos2[mejoresNodos1[mejorSeleecion0]]]].ToString(), " , ",
                        Analisis4Nodo_Text[mejoresNodos4[mejoresNodos3[mejoresNodos2[mejoresNodos1[mejorSeleecion0]]]]].ToString()
                        );

                }


                Ajedrez_main.posicionesFinales = totalNodos.ToString();


                StreamWriter huo_sw5 = new StreamWriter("HUO_CHESS_LOG_Minmax_After.txt", true);


                if (mejorMovimientoNumeroColumna > 0)
                {
                    piezaMoviendose = Skakiera[(mejorMovimientoNumeroColumna - 1), (mejorMovimientoRankingInicial - 1)];
                    Skakiera[(mejorMovimientoNumeroColumna - 1), (mejorMovimientoRankingInicial - 1)] = "";

                    if (mejorMovimientoNumeroColumna == 1)
                        HY_inicioColumnaTexto = "a";
                    else if (mejorMovimientoNumeroColumna == 2)
                        HY_inicioColumnaTexto = "b";
                    else if (mejorMovimientoNumeroColumna == 3)
                        HY_inicioColumnaTexto = "c";
                    else if (mejorMovimientoNumeroColumna == 4)
                        HY_inicioColumnaTexto = "d";
                    else if (mejorMovimientoNumeroColumna == 5)
                        HY_inicioColumnaTexto = "e";
                    else if (mejorMovimientoNumeroColumna == 6)
                        HY_inicioColumnaTexto = "f";
                    else if (mejorMovimientoNumeroColumna == 7)
                        HY_inicioColumnaTexto = "g";
                    else if (mejorMovimientoNumeroColumna == 8)
                        HY_inicioColumnaTexto = "h";


                    Skakiera[(mejorMovimientoFinalizarColumnNumer - 1), (mejorMovimientoRankFinalizar - 1)] = piezaMoviendose;

                    if (mejorMovimientoFinalizarColumnNumer == 1)
                        HY_Finishing_Column_Text = "a";
                    else if (mejorMovimientoFinalizarColumnNumer == 2)
                        HY_Finishing_Column_Text = "b";
                    else if (mejorMovimientoFinalizarColumnNumer == 3)
                        HY_Finishing_Column_Text = "c";
                    else if (mejorMovimientoFinalizarColumnNumer == 4)
                        HY_Finishing_Column_Text = "d";
                    else if (mejorMovimientoFinalizarColumnNumer == 5)
                        HY_Finishing_Column_Text = "e";
                    else if (mejorMovimientoFinalizarColumnNumer == 6)
                        HY_Finishing_Column_Text = "f";
                    else if (mejorMovimientoFinalizarColumnNumer == 7)
                        HY_Finishing_Column_Text = "g";
                    else if (mejorMovimientoFinalizarColumnNumer == 8)
                        HY_Finishing_Column_Text = "h";

                    PawnPromotion();

                    siguienteLinea = String.Concat(HY_inicioColumnaTexto, mejorMovimientoRankingInicial.ToString(), " -> ", HY_Finishing_Column_Text, mejorMovimientoRankFinalizar.ToString());

                    numeroMovimientosAnalizados = 0;




                    if (mColorJugsdor.CompareTo("Black") == 0)
                    {
                        colorJugando = "Black";
                        movimeinto = movimeinto + 1;
                    }
                    else if (mColorJugsdor.CompareTo("White") == 0)
                        colorJugando = "White";

                    ActualJugando = "Human";
                }

                else
                {
                    MessageBox.Show("I resign!");

                }
            }

            public static int contarPuntaje(string[,] CSSkakiera)
            {
                int Score_Multiplier_White = 1;
                int Score_Multiplier_Black = 1;
                int WhiteKingColumn = 0;
                int WhiteKingRank = 0;
                int BlackKingColumn = 0;
                int BlackKingRank = 0;


                for (i = 0; i <= 7; i++)
                {
                    for (j = 0; j <= 7; j++)
                    {
                        if (CSSkakiera[(i), (j)].CompareTo("White King") == 0)
                        {
                            WhiteKingColumn = i;
                            WhiteKingRank = j;
                        }
                        if (CSSkakiera[(i), (j)].CompareTo("Black King") == 0)
                        {
                            BlackKingColumn = i;
                            BlackKingRank = j;
                        }
                    }
                }



                puntuacionMovimientoActual = 0;

                if (movimientoInutil.CompareTo("Y") == 0)
                {
                    if (mColorJugsdor.CompareTo("White") == 0)
                        puntuacionMovimientoActual = puntuacionMovimientoActual + 1;
                    else if (mColorJugsdor.CompareTo("Black") == 0)
                        puntuacionMovimientoActual = puntuacionMovimientoActual - 1;
                }

                if ((Skakiera_cuadros_peligro[(columnaFinaliza - 1), (m_FinishingRank - 1)] != 0))
                {
                    if (mColorJugsdor.CompareTo("White") == 0)
                        puntuacionMovimientoActual = puntuacionMovimientoActual + 1;
                    else if (mColorJugsdor.CompareTo("Black") == 0)
                        puntuacionMovimientoActual = puntuacionMovimientoActual - 1;
                }


                if ((puedeComer == true))
                {
                    if (mColorJugsdor.CompareTo("White") == 0)
                        puntuacionMovimientoActual = puntuacionMovimientoActual - 1;
                    else if (mColorJugsdor.CompareTo("Black") == 0)
                        puntuacionMovimientoActual = puntuacionMovimientoActual + 1;
                }

                for (i = 0; i <= 7; i++)
                {
                    for (j = 0; j <= 7; j++)
                    {
                        if (CSSkakiera[(i), (j)].CompareTo("White Pawn") == 0)
                        {

                            puntuacionMovimientoActual = puntuacionMovimientoActual + 10 * Score_Multiplier_White;

                            if ((movimeinto > 10) && (j > 2))
                            {
                                puntuacionMovimientoActual = puntuacionMovimientoActual + 3 * Score_Multiplier_White;
                            }
                            if ((movimeinto > 30) && (j > 4))
                            {
                                puntuacionMovimientoActual = puntuacionMovimientoActual + 10 * Score_Multiplier_White;
                            }
                            if ((movimeinto > 30) && (j == 7))
                            {
                                puntuacionMovimientoActual = puntuacionMovimientoActual + 90 * Score_Multiplier_White;
                            }
                        }
                        else if (CSSkakiera[(i), (j)].CompareTo("White Rook") == 0)
                        {

                            puntuacionMovimientoActual = puntuacionMovimientoActual + 50 * Score_Multiplier_White;


                        }
                        else if (CSSkakiera[(i), (j)].CompareTo("White Knight") == 0)
                        {

                            puntuacionMovimientoActual = puntuacionMovimientoActual + 30 * Score_Multiplier_White;


                            if ((movimeinto > 40) && (Math.Abs(i - BlackKingColumn) < 4))
                            {
                                puntuacionMovimientoActual = puntuacionMovimientoActual + 4 * Score_Multiplier_White;
                            }
                            if ((movimeinto > 40) && (Math.Abs(j - BlackKingRank) < 4))
                            {
                                puntuacionMovimientoActual = puntuacionMovimientoActual + 4 * Score_Multiplier_White;
                            }
                        }
                        else if (CSSkakiera[(i), (j)].CompareTo("White Bishop") == 0)
                        {

                            puntuacionMovimientoActual = puntuacionMovimientoActual + 30 * Score_Multiplier_White;


                        }
                        else if (CSSkakiera[(i), (j)].CompareTo("White Queen") == 0)
                        {

                            puntuacionMovimientoActual = puntuacionMovimientoActual + 90 * Score_Multiplier_White;


                        }
                        else if (CSSkakiera[(i), (j)].CompareTo("White King") == 0)
                        {

                            puntuacionMovimientoActual = puntuacionMovimientoActual + 150 * Score_Multiplier_White;
                        }
                        else if (CSSkakiera[(i), (j)].CompareTo("Black Pawn") == 0)
                        {

                            puntuacionMovimientoActual = puntuacionMovimientoActual - 10 * Score_Multiplier_Black;

                            if ((movimeinto > 10) && (j < 6))
                            {
                                puntuacionMovimientoActual = puntuacionMovimientoActual - 3 * Score_Multiplier_Black;
                            }
                            if ((movimeinto > 30) && (j < 5))
                            {
                                puntuacionMovimientoActual = puntuacionMovimientoActual - 10 * Score_Multiplier_Black;
                            }
                            if ((movimeinto > 30) && (j == 0))
                            {
                                puntuacionMovimientoActual = puntuacionMovimientoActual - 90 * Score_Multiplier_Black;
                            }
                        }
                        else if (CSSkakiera[(i), (j)].CompareTo("Black Rook") == 0)
                        {

                            puntuacionMovimientoActual = puntuacionMovimientoActual - 50 * Score_Multiplier_Black;

                        }
                        else if (CSSkakiera[(i), (j)].CompareTo("Black Knight") == 0)
                        {

                            puntuacionMovimientoActual = puntuacionMovimientoActual - 30 * Score_Multiplier_Black;

                            if ((movimeinto > 40) && (Math.Abs(i - WhiteKingColumn) < 4))
                            {
                                puntuacionMovimientoActual = puntuacionMovimientoActual - 4 * Score_Multiplier_White;
                            }
                            if ((movimeinto > 40) && (Math.Abs(j - WhiteKingRank) < 4))
                            {
                                puntuacionMovimientoActual = puntuacionMovimientoActual - 4 * Score_Multiplier_White;
                            }
                        }
                        else if (CSSkakiera[(i), (j)].CompareTo("Black Bishop") == 0)
                        {

                            puntuacionMovimientoActual = puntuacionMovimientoActual - 30 * Score_Multiplier_Black;


                        }
                        else if (CSSkakiera[(i), (j)].CompareTo("Black Queen") == 0)
                        {

                            puntuacionMovimientoActual = puntuacionMovimientoActual - 90 * Score_Multiplier_Black;

                        }
                        else if (CSSkakiera[(i), (j)].CompareTo("Black King") == 0)
                        {

                            puntuacionMovimientoActual = puntuacionMovimientoActual - 150 * Score_Multiplier_Black;
                        }

                    }
                }


                if (CSSkakiera[3, 3].CompareTo("White Pawn") == 0)
                {
                    puntuacionMovimientoActual = puntuacionMovimientoActual + 1;
                }
                if (CSSkakiera[4, 3].CompareTo("White Pawn") == 0)
                {
                    puntuacionMovimientoActual = puntuacionMovimientoActual + 1;
                }
                if (CSSkakiera[3, 4].CompareTo("Black Pawn") == 0)
                {
                    puntuacionMovimientoActual = puntuacionMovimientoActual - 1;
                }
                if (CSSkakiera[4, 4].CompareTo("Black Pawn") == 0)
                {
                    puntuacionMovimientoActual = puntuacionMovimientoActual - 1;
                }


                if (movimeinto < 10)
                {

                    if (CSSkakiera[1, 0].CompareTo("White Knight") == 0)
                    {
                        puntuacionMovimientoActual = puntuacionMovimientoActual - 1;
                    }
                    if (CSSkakiera[6, 0].CompareTo("White Knight") == 0)
                    {
                        puntuacionMovimientoActual = puntuacionMovimientoActual - 1;
                    }

                    if (CSSkakiera[2, 0].CompareTo("White Bishop") == 0)
                    {
                        puntuacionMovimientoActual = puntuacionMovimientoActual - 1;
                    }
                    if (CSSkakiera[5, 0].CompareTo("White Bishop") == 0)
                    {
                        puntuacionMovimientoActual = puntuacionMovimientoActual - 1;
                    }

                    if (CSSkakiera[0, 0].CompareTo("") == 0)
                    {
                        puntuacionMovimientoActual = puntuacionMovimientoActual - 1;
                    }
                    if (CSSkakiera[7, 0].CompareTo("") == 0)
                    {
                        puntuacionMovimientoActual = puntuacionMovimientoActual - 1;
                    }

                    if (CSSkakiera[0, 2].CompareTo("White Knight") == 0)
                    {
                        puntuacionMovimientoActual = puntuacionMovimientoActual - 1;
                    }
                    if (CSSkakiera[7, 2].CompareTo("White Knight") == 0)
                    {
                        puntuacionMovimientoActual = puntuacionMovimientoActual - 1;
                    }

                    if (CSSkakiera[0, 3].CompareTo("White Pawn") == 0)
                    {
                        puntuacionMovimientoActual = puntuacionMovimientoActual - 1;
                    }
                    if (CSSkakiera[7, 3].CompareTo("White Pawn") == 0)
                    {
                        puntuacionMovimientoActual = puntuacionMovimientoActual - 1;
                    }

                    if (CSSkakiera[3, 0].CompareTo("") == 0)
                    {
                        puntuacionMovimientoActual = puntuacionMovimientoActual - 1;
                    }

                    if (CSSkakiera[1, 7].CompareTo("Black Knight") == 0)
                    {
                        puntuacionMovimientoActual = puntuacionMovimientoActual + 1;
                    }
                    if (CSSkakiera[6, 7].CompareTo("Black Knight") == 0)
                    {
                        puntuacionMovimientoActual = puntuacionMovimientoActual + 1;
                    }

                    if (CSSkakiera[2, 7].CompareTo("Black Bishop") == 0)
                    {
                        puntuacionMovimientoActual = puntuacionMovimientoActual + 1;
                    }
                    if (CSSkakiera[5, 7].CompareTo("Black Bishop") == 0)
                    {
                        puntuacionMovimientoActual = puntuacionMovimientoActual + 1;
                    }

                    if (CSSkakiera[0, 7].CompareTo("") == 0)
                    {
                        puntuacionMovimientoActual = puntuacionMovimientoActual + 1;
                    }
                    if (CSSkakiera[7, 7].CompareTo("") == 0)
                    {
                        puntuacionMovimientoActual = puntuacionMovimientoActual + 1;
                    }

                    if (CSSkakiera[0, 5].CompareTo("Black Knight") == 0)
                    {
                        puntuacionMovimientoActual = puntuacionMovimientoActual + 1;
                    }
                    if (CSSkakiera[7, 5].CompareTo("Black Knight") == 0)
                    {
                        puntuacionMovimientoActual = puntuacionMovimientoActual + 1;
                    }

                    if (CSSkakiera[0, 4].CompareTo("Black Pawn") == 0)
                    {
                        puntuacionMovimientoActual = puntuacionMovimientoActual + 1;
                    }
                    if (CSSkakiera[7, 4].CompareTo("Black Pawn") == 0)
                    {
                        puntuacionMovimientoActual = puntuacionMovimientoActual + 1;
                    }

                    if (CSSkakiera[3, 7].CompareTo("") == 0)
                    {
                        puntuacionMovimientoActual = puntuacionMovimientoActual + 1;
                    }

                }


                chequeoReyBlanco = chequeoBlanca(CSSkakiera);
                BlackKingCheck = ChequeoNegro(CSSkakiera);

                if ((mColorJugsdor.CompareTo("White") == 0) && (numeroColumnaInicial == 5) && (columnaFinaliza == 7) && (m_StartingRank == 1) && (m_FinishingRank == 1))
                {
                    if ((Skakiera[(numeroColumnaInicial - 1), (m_StartingRank - 1)].CompareTo("White King") == 0) && (Skakiera[(7), (0)].CompareTo("White Rook") == 0) && (Skakiera[(5), (0)].CompareTo("") == 0) && (Skakiera[(6), (0)].CompareTo("") == 0))
                    {
                        m_OrthotitaKinisis = true;
                        m_NomimotitaKinisis = true;
                        Castling_Occured = true;
                    }
                }


                if ((mColorJugsdor.CompareTo("White") == 0) && (numeroColumnaInicial == 5) && (columnaFinaliza == 3) && (m_StartingRank == 1) && (m_FinishingRank == 1))
                {
                    if ((Skakiera[(numeroColumnaInicial - 1), (m_StartingRank - 1)].CompareTo("White King") == 0) && (Skakiera[(0), (0)].CompareTo("White Rook") == 0) && (Skakiera[(1), (0)].CompareTo("") == 0) && (Skakiera[(2), (0)].CompareTo("") == 0) && (Skakiera[(3), (0)].CompareTo("") == 0))
                    {
                        m_OrthotitaKinisis = true;
                        m_NomimotitaKinisis = true;
                        Castling_Occured = true;
                    }
                }


                if ((mColorJugsdor.CompareTo("Black") == 0) && (numeroColumnaInicial == 5) && (columnaFinaliza == 7) && (m_StartingRank == 8) && (m_FinishingRank == 8))
                {
                    if ((Skakiera[(numeroColumnaInicial - 1), (m_StartingRank - 1)].CompareTo("Black King") == 0) && (Skakiera[(7), (7)].CompareTo("Black Rook") == 0) && (Skakiera[(5), (7)].CompareTo("") == 0) && (Skakiera[(6), (7)].CompareTo("") == 0))
                    {
                        m_OrthotitaKinisis = true;
                        m_NomimotitaKinisis = true;
                        Castling_Occured = true;
                    }
                }


                if ((mColorJugsdor.CompareTo("Black") == 0) && (numeroColumnaInicial == 5) && (columnaFinaliza == 3) && (m_StartingRank == 8) && (m_FinishingRank == 8))
                {
                    if ((Skakiera[(numeroColumnaInicial - 1), (m_StartingRank - 1)].CompareTo("Black King") == 0) && (Skakiera[(0), (7)].CompareTo("Black Rook") == 0) && (Skakiera[(1), (7)].CompareTo("") == 0) && (Skakiera[(2), (7)].CompareTo("") == 0) && (Skakiera[(3), (7)].CompareTo("") == 0))
                    {
                        m_OrthotitaKinisis = true;
                        m_NomimotitaKinisis = true;
                        Castling_Occured = true;
                    }
                }



                if (movimeinto > 40)
                {

                    if (chequeoReyBlanco == true)
                    {
                        puntuacionMovimientoActual = puntuacionMovimientoActual - 10 * Score_Multiplier_Black;
                    }
                    if (BlackKingCheck == true)
                    {
                        puntuacionMovimientoActual = puntuacionMovimientoActual + 10 * Score_Multiplier_White;
                    }
                }

                return puntuacionMovimientoActual;
            }
            public static bool ElegxosNomimotitas(string[,] ENSkakiera, int checkForDanger, int startRank, int startColumn, int finishRank, int finishColumn, String MovingPiece_EN)
            {
                String ProsorinoKommati_EN;


                bool Nomimotita;


                Nomimotita = true;

                if (((finishRank - 1) > 7) || ((finishRank - 1) < 0) || ((finishColumn - 1) > 7) || ((finishColumn - 1) < 0))
                    Nomimotita = false;

                if (checkForDanger == 0)
                {
                    if ((MovingPiece_EN.CompareTo("White King") == 0) || (MovingPiece_EN.CompareTo("White Queen") == 0) || (MovingPiece_EN.CompareTo("White Rook") == 0) || (MovingPiece_EN.CompareTo("White Knight") == 0) || (MovingPiece_EN.CompareTo("White Bishop") == 0) || (MovingPiece_EN.CompareTo("White Pawn") == 0))
                    {
                        if ((ENSkakiera[((finishColumn - 1)), ((finishRank - 1))].CompareTo("White King") == 0) || (ENSkakiera[((finishColumn - 1)), ((finishRank - 1))].CompareTo("White Queen") == 0) || (ENSkakiera[((finishColumn - 1)), ((finishRank - 1))].CompareTo("White Rook") == 0) || (ENSkakiera[((finishColumn - 1)), ((finishRank - 1))].CompareTo("White Knight") == 0) || (ENSkakiera[((finishColumn - 1)), ((finishRank - 1))].CompareTo("White Bishop") == 0) || (ENSkakiera[((finishColumn - 1)), ((finishRank - 1))].CompareTo("White Pawn") == 0))
                        {
                            Nomimotita = false;
                        }
                    }
                    else if ((MovingPiece_EN.CompareTo("Black King") == 0) || (MovingPiece_EN.CompareTo("Black Queen") == 0) || (MovingPiece_EN.CompareTo("Black Rook") == 0) || (MovingPiece_EN.CompareTo("Black Knight") == 0) || (MovingPiece_EN.CompareTo("Black Bishop") == 0) || (MovingPiece_EN.CompareTo("Black Pawn") == 0))
                    {
                        if ((ENSkakiera[((finishColumn - 1)), ((finishRank - 1))].CompareTo("Black King") == 0) || (ENSkakiera[((finishColumn - 1)), ((finishRank - 1))].CompareTo("Black Queen") == 0) || (ENSkakiera[((finishColumn - 1)), ((finishRank - 1))].CompareTo("Black Rook") == 0) || (ENSkakiera[((finishColumn - 1)), ((finishRank - 1))].CompareTo("Black Knight") == 0) || (ENSkakiera[((finishColumn - 1)), ((finishRank - 1))].CompareTo("Black Bishop") == 0) || (ENSkakiera[((finishColumn - 1)), ((finishRank - 1))].CompareTo("Black Pawn") == 0))
                            Nomimotita = false;
                    }
                }

                if (MovingPiece_EN.CompareTo("White King") == 0)
                {
                    if (checkForDanger == 0)
                    {

                        ENSkakiera[(startColumn - 1), (startRank - 1)] = "";
                        ProsorinoKommati_EN = ENSkakiera[(finishColumn - 1), (finishRank - 1)];
                        ENSkakiera[(finishColumn - 1), (finishRank - 1)] = "White King";

                        chequeoReyBlanco = chequeoBlanca(ENSkakiera);



                        if (chequeoReyBlanco == true)
                            Nomimotita = false;

                        ENSkakiera[(finishColumn - 1), (finishRank - 1)] = ProsorinoKommati_EN;
                        ENSkakiera[(startColumn - 1), (startRank - 1)] = "White King";
                    }
                }
                else if (MovingPiece_EN.CompareTo("Black King") == 0)
                {
                    if (checkForDanger == 0)
                    {

                        ENSkakiera[(startColumn - 1), (startRank - 1)] = "";
                        ProsorinoKommati_EN = ENSkakiera[(finishColumn - 1), (finishRank - 1)];
                        ENSkakiera[(finishColumn - 1), (finishRank - 1)] = "Black King";

                        BlackKingCheck = ChequeoNegro(ENSkakiera);

                        if (BlackKingCheck == true)
                            Nomimotita = false;


                        ENSkakiera[(finishColumn - 1), (finishRank - 1)] = ProsorinoKommati_EN; //v0.990 ProsorinoKommati_KingCheck;
                        ENSkakiera[(startColumn - 1), (startRank - 1)] = "Black King";
                    }
                }
                else if (MovingPiece_EN.CompareTo("White Pawn") == 0)
                {
                    if (checkForDanger == 0)
                    {


                        if ((finishRank == (startRank + 1)) && (finishColumn == startColumn))
                        {
                            if (ENSkakiera[(finishColumn - 1), (finishRank - 1)].CompareTo("") == 1)
                            {
                                Nomimotita = false;
                            }
                        }

                        else if ((finishRank == (startRank + 2)) && (finishColumn == startColumn))
                        {
                            if (startRank == 2)
                            {
                                if ((ENSkakiera[(finishColumn - 1), (finishRank - 1)].CompareTo("") == 1) || (ENSkakiera[(finishColumn - 1), (finishRank - 1 - 1)].CompareTo("") == 1))
                                    Nomimotita = false;
                            }
                        }


                        else if ((finishRank == (startRank + 1)) && (finishColumn == startColumn + 1))
                        {
                            if (enpassant_occured == false)
                            {
                                if (ENSkakiera[(finishColumn - 1), (finishRank - 1)].CompareTo("") == 0)
                                    Nomimotita = false;
                            }
                        }


                        else if ((finishRank == (startRank + 1)) && (finishColumn == startColumn - 1))
                        {
                            if (enpassant_occured == false)
                            {
                                if (ENSkakiera[(finishColumn - 1), (finishRank - 1)].CompareTo("") == 0)
                                    Nomimotita = false;
                            }
                        }
                    }
                }
                else if (MovingPiece_EN.CompareTo("Black Pawn") == 0)
                {
                    if (checkForDanger == 0)
                    {

                        if ((finishRank == (startRank - 1)) && (finishColumn == startColumn))
                        {
                            if (ENSkakiera[(finishColumn - 1), (finishRank - 1)].CompareTo("") == 1)
                                Nomimotita = false;
                        }

                        else if ((finishRank == (startRank - 2)) && (finishColumn == startColumn))
                        {
                            if (startRank == 7)
                            {
                                if ((ENSkakiera[(finishColumn - 1), (finishRank - 1)].CompareTo("") == 1) || (ENSkakiera[(finishColumn - 1), (finishRank + 1 - 1)].CompareTo("") == 1))
                                    Nomimotita = false;
                            }
                        }


                        else if ((finishRank == (startRank - 1)) && (finishColumn == startColumn + 1))
                        {
                            if (enpassant_occured == false)
                            {
                                if (ENSkakiera[(finishColumn - 1), (finishRank - 1)].CompareTo("") == 0)
                                    Nomimotita = false;
                            }
                        }


                        else if ((finishRank == (startRank - 1)) && (finishColumn == startColumn - 1))
                        {
                            if (enpassant_occured == false)
                            {
                                if (ENSkakiera[(finishColumn - 1), (finishRank - 1)].CompareTo("") == 0)
                                    Nomimotita = false;
                            }
                        }
                    }
                }
                else if ((MovingPiece_EN.CompareTo("White Rook") == 0) || (MovingPiece_EN.CompareTo("White Queen") == 0) || (MovingPiece_EN.CompareTo("White Bishop") == 0) || (MovingPiece_EN.CompareTo("Black Rook") == 0) || (MovingPiece_EN.CompareTo("Black Queen") == 0) || (MovingPiece_EN.CompareTo("Black Bishop") == 0))
                {
                    h = 0;
                    p = 0;
                    how_to_move_Rank = 0;
                    comoMoverColumna = 0;

                    if (((finishRank - 1) > (startRank - 1)) || ((finishRank - 1) < (startRank - 1)))
                        how_to_move_Rank = ((finishRank - 1) - (startRank - 1)) / System.Math.Abs((finishRank - 1) - (startRank - 1));

                    if (((finishColumn - 1) > (startColumn - 1)) || ((finishColumn - 1) < (startColumn - 1)))
                        comoMoverColumna = ((finishColumn - 1) - (startColumn - 1)) / System.Math.Abs((finishColumn - 1) - (startColumn - 1));

                    exit_elegxos_nomimothtas = false;

                    do
                    {
                        h = h + how_to_move_Rank;
                        p = p + comoMoverColumna;

                        if ((((startRank - 1) + h) == (finishRank - 1)) && ((((startColumn - 1) + p)) == (finishColumn - 1)))
                            exit_elegxos_nomimothtas = true;

                        if ((startColumn - 1 + p) < 0)
                            exit_elegxos_nomimothtas = true;
                        else if ((startRank - 1 + h) < 0)
                            exit_elegxos_nomimothtas = true;
                        else if ((startColumn - 1 + p) > 7)
                            exit_elegxos_nomimothtas = true;
                        else if ((startRank - 1 + h) > 7)
                            exit_elegxos_nomimothtas = true;

                        if (exit_elegxos_nomimothtas == false)
                        {
                            if (ENSkakiera[(startColumn - 1 + p), (startRank - 1 + h)].CompareTo("White Rook") == 0)
                            {
                                Nomimotita = false;
                                exit_elegxos_nomimothtas = true;
                            }
                            else if (ENSkakiera[(startColumn - 1 + p), (startRank - 1 + h)].CompareTo("White Knight") == 0)
                            {
                                Nomimotita = false;
                                exit_elegxos_nomimothtas = true;
                            }
                            else if (ENSkakiera[(startColumn - 1 + p), (startRank - 1 + h)].CompareTo("White Bishop") == 0)
                            {
                                Nomimotita = false;
                                exit_elegxos_nomimothtas = true;
                            }
                            else if (ENSkakiera[(startColumn - 1 + p), (startRank - 1 + h)].CompareTo("White Queen") == 0)
                            {
                                Nomimotita = false;
                                exit_elegxos_nomimothtas = true;
                            }
                            else if (ENSkakiera[(startColumn - 1 + p), (startRank - 1 + h)].CompareTo("White King") == 0)
                            {
                                Nomimotita = false;
                                exit_elegxos_nomimothtas = true;
                            }
                            else if (ENSkakiera[(startColumn - 1 + p), (startRank - 1 + h)].CompareTo("White Pawn") == 0)
                            {
                                Nomimotita = false;
                                exit_elegxos_nomimothtas = true;
                            }

                            if (ENSkakiera[(startColumn - 1 + p), (startRank - 1 + h)].CompareTo("Black Rook") == 0)
                            {
                                Nomimotita = false;
                                exit_elegxos_nomimothtas = true;
                            }
                            else if (ENSkakiera[(startColumn - 1 + p), (startRank - 1 + h)].CompareTo("Black Knight") == 0)
                            {
                                Nomimotita = false;
                                exit_elegxos_nomimothtas = true;
                            }
                            else if (ENSkakiera[(startColumn - 1 + p), (startRank - 1 + h)].CompareTo("Black Bishop") == 0)
                            {
                                Nomimotita = false;
                                exit_elegxos_nomimothtas = true;
                            }
                            else if (ENSkakiera[(startColumn - 1 + p), (startRank - 1 + h)].CompareTo("Black Queen") == 0)
                            {
                                Nomimotita = false;
                                exit_elegxos_nomimothtas = true;
                            }
                            else if (ENSkakiera[(startColumn - 1 + p), (startRank - 1 + h)].CompareTo("Black King") == 0)
                            {
                                Nomimotita = false;
                                exit_elegxos_nomimothtas = true;
                            }
                            else if (ENSkakiera[(startColumn - 1 + p), (startRank - 1 + h)].CompareTo("Black Pawn") == 0)
                            {
                                Nomimotita = false;
                                exit_elegxos_nomimothtas = true;
                            }
                        }
                    } while (exit_elegxos_nomimothtas == false);
                }

                if ((Nomimotita == true) && (movimientoAnalizado < 2))
                {

                    ENSkakiera[(startColumn - 1), (startRank - 1)] = "";
                    ProsorinoKommati_EN = ENSkakiera[(finishColumn - 1), (finishRank - 1)];
                    ENSkakiera[(finishColumn - 1), (finishRank - 1)] = MovingPiece_EN;


                    if (colorJugando.CompareTo("White") == 0)
                    {
                        chequeoReyBlanco = chequeoBlanca(ENSkakiera);
                    }
                    else if (colorJugando.CompareTo("Black") == 0)
                    {
                        BlackKingCheck = ChequeoNegro(ENSkakiera);
                    }

                    if ((colorJugando.CompareTo("White") == 0) && (chequeoReyBlanco == true))
                    {
                        Nomimotita = false;
                    }
                    if ((colorJugando.CompareTo("Black") == 0) && (BlackKingCheck == true))
                    {
                        Nomimotita = false;
                    }

                    ENSkakiera[(finishColumn - 1), (finishRank - 1)] = ProsorinoKommati_EN;
                    ENSkakiera[(startColumn - 1), (startRank - 1)] = MovingPiece_EN;
                }

                return Nomimotita;
            }

            public static bool ElegxosOrthotitas(string[,] EOSkakiera, int checkForDanger, int startRank, int startColumn, int finishRank, int finishColumn, String MovingPiece_EO)
            {


                bool Orthotita;
                Orthotita = false;
                enpassant_occured = false;


                if ((ActualJugando.CompareTo("Human") == 0) && (m_WrongColumn == false) && (MovingPiece_EO.CompareTo("") == 1))
                {
                    if ((MovingPiece_EO.CompareTo("White Rook") == 0) || (MovingPiece_EO.CompareTo("Black Rook") == 0))
                    {
                        if ((finishColumn != startColumn) && (finishRank == startRank))
                            Orthotita = true;
                        else if ((finishRank != startRank) && (finishColumn == startColumn))
                            Orthotita = true;
                    }

                    // Horse (with knight...)

                    if ((MovingPiece_EO.CompareTo("White Knight") == 0) || (MovingPiece_EO.CompareTo("Black Knight") == 0))
                    {
                        if ((finishColumn == (startColumn + 1)) && (finishRank == (startRank + 2)))
                            Orthotita = true;
                        else if ((finishColumn == (startColumn + 2)) && (finishRank == (startRank - 1)))
                            Orthotita = true;
                        else if ((finishColumn == (startColumn + 1)) && (finishRank == (startRank - 2)))
                            Orthotita = true;
                        else if ((finishColumn == (startColumn - 1)) && (finishRank == (startRank - 2)))
                            Orthotita = true;
                        else if ((finishColumn == (startColumn - 2)) && (finishRank == (startRank - 1)))
                            Orthotita = true;
                        else if ((finishColumn == (startColumn - 2)) && (finishRank == (startRank + 1)))
                            Orthotita = true;
                        else if ((finishColumn == (startColumn - 1)) && (finishRank == (startRank + 2)))
                            Orthotita = true;
                        else if ((finishColumn == (startColumn + 2)) && (finishRank == (startRank + 1)))
                            Orthotita = true;
                    }


                    if ((MovingPiece_EO.CompareTo("White Bishop") == 0) || (MovingPiece_EO.CompareTo("Black Bishop") == 0))
                    {
                        if (((Math.Abs(finishColumn - startColumn)) == (Math.Abs(finishRank - startRank))) && (finishColumn != startColumn) && (finishRank != startRank))
                            Orthotita = true;

                    }


                    if ((MovingPiece_EO.CompareTo("White Queen") == 0) || (MovingPiece_EO.CompareTo("Black Queen") == 0))
                    {
                        if ((finishColumn != startColumn) && (finishRank == startRank))       // Κίνηση σε στήλη
                            Orthotita = true;
                        else if ((finishRank != startRank) && (finishColumn == startColumn))  // Κίνηση σε γραμμή
                            Orthotita = true;

                        if (((Math.Abs(finishColumn - startColumn)) == (Math.Abs(finishRank - startRank))) && (finishColumn != startColumn) && (finishRank != startRank))
                            Orthotita = true;

                    }



                    if ((MovingPiece_EO.CompareTo("White King") == 0) || (MovingPiece_EO.CompareTo("Black King") == 0))
                    {

                        if ((finishColumn == (startColumn + 1)) && (finishRank == startRank))
                            Orthotita = true;
                        else if ((finishColumn == (startColumn - 1)) && (finishRank == startRank))
                            Orthotita = true;
                        else if ((finishRank == (startRank + 1)) && (finishColumn == startColumn))
                            Orthotita = true;
                        else if ((finishRank == (startRank - 1)) && (finishColumn == startColumn))
                            Orthotita = true;

                        else if ((finishColumn == (startColumn + 1)) && (finishRank == (startRank + 1)))
                            Orthotita = true;
                        else if ((finishColumn == (startColumn + 1)) && (finishRank == (startRank - 1)))
                            Orthotita = true;
                        else if ((finishColumn == (startColumn - 1)) && (finishRank == (startRank - 1)))
                            Orthotita = true;
                        else if ((finishColumn == (startColumn - 1)) && (finishRank == (startRank + 1)))
                            Orthotita = true;

                    }


                    if (MovingPiece_EO.CompareTo("White Pawn") == 0)
                    {


                        if ((finishRank == (startRank + 1)) && (finishColumn == startColumn))
                            Orthotita = true;


                        else if ((finishRank == (startRank + 2)) && (finishColumn == startColumn) && (startRank == 2))
                            Orthotita = true;

                        else if ((finishRank == (startRank + 1)) && ((finishColumn == (startColumn - 1)) || (finishColumn == (startColumn + 1))))
                        {
                            if (checkForDanger == 0)
                            {

                                if ((finishRank == (startRank + 1)) && (finishColumn == (startColumn - 1)) && ((EOSkakiera[(finishColumn - 1), (finishRank - 1)].CompareTo("Black Pawn") == 0) || (EOSkakiera[(finishColumn - 1), (finishRank - 1)].CompareTo("Black Rook") == 0) || (EOSkakiera[(finishColumn - 1), (finishRank - 1)].CompareTo("Black Knight") == 0) || (EOSkakiera[(finishColumn - 1), (finishRank - 1)].CompareTo("Black Bishop") == 0) || (EOSkakiera[(finishColumn - 1), (finishRank - 1)].CompareTo("Black Queen") == 0)))
                                    Orthotita = true;


                                if ((finishRank == (startRank + 1)) && (finishColumn == (startColumn + 1)) && ((EOSkakiera[(finishColumn - 1), (finishRank - 1)].CompareTo("Black Pawn") == 0) || (EOSkakiera[(finishColumn - 1), (finishRank - 1)].CompareTo("Black Rook") == 0) || (EOSkakiera[(finishColumn - 1), (finishRank - 1)].CompareTo("Black Knight") == 0) || (EOSkakiera[(finishColumn - 1), (finishRank - 1)].CompareTo("Black Bishop") == 0) || (EOSkakiera[(finishColumn - 1), (finishRank - 1)].CompareTo("Black Queen") == 0)))
                                    Orthotita = true;
                            }
                            else if (checkForDanger == 1)
                            {
                                Orthotita = true;
                            }
                        }


                        else if ((finishRank == (startRank + 1)) && (finishColumn == (startColumn - 1)))
                        {
                            if (checkForDanger == 0)
                            {
                                if ((finishRank == 6) && (EOSkakiera[(finishColumn - 1), (4)].CompareTo("Black Pawn") == 0))
                                {
                                    Orthotita = true;
                                    enpassant_occured = true;
                                    EOSkakiera[(finishColumn - 1), (finishRank - 1 - 1)] = "";

                                }
                                else
                                {
                                    Orthotita = false;
                                    enpassant_occured = false;
                                }
                            }
                        }
                        else if ((finishRank == (startRank + 1)) && (finishColumn == (startColumn + 1)))
                        {
                            if (checkForDanger == 0)
                            {
                                if ((finishRank == 6) && (EOSkakiera[(finishColumn - 1), (4)].CompareTo("Black Pawn") == 0))
                                {
                                    Orthotita = true;
                                    enpassant_occured = true;
                                    EOSkakiera[(finishColumn - 1), (finishRank - 1 - 1)] = "";
                                }
                                else
                                {
                                    Orthotita = false;
                                    enpassant_occured = false;
                                }
                            }
                        }

                    }



                    if (MovingPiece_EO.CompareTo("Black Pawn") == 0)
                    {


                        if ((finishRank == (startRank - 1)) && (finishColumn == startColumn))
                            Orthotita = true;


                        else if ((finishRank == (startRank - 2)) && (finishColumn == startColumn) && (startRank == 7))
                            Orthotita = true;

                        else if ((finishRank == (startRank - 1)) && ((finishColumn == (startColumn + 1)) || (finishColumn == (startColumn - 1))))
                        {
                            if (checkForDanger == 0)
                            {

                                if ((finishRank == (startRank - 1)) && (finishColumn == (startColumn + 1)) && ((EOSkakiera[(finishColumn - 1), (finishRank - 1)].CompareTo("White Pawn") == 0) || (EOSkakiera[(finishColumn - 1), (finishRank - 1)].CompareTo("White Rook") == 0) || (EOSkakiera[(finishColumn - 1), (finishRank - 1)].CompareTo("White Knight") == 0) || (EOSkakiera[(finishColumn - 1), (finishRank - 1)].CompareTo("White Bishop") == 0) || (EOSkakiera[(finishColumn - 1), (finishRank - 1)].CompareTo("White Queen") == 0)))
                                    Orthotita = true;


                                if ((finishRank == (startRank - 1)) && (finishColumn == (startColumn - 1)) && ((EOSkakiera[(finishColumn - 1), (finishRank - 1)].CompareTo("White Pawn") == 0) || (EOSkakiera[(finishColumn - 1), (finishRank - 1)].CompareTo("White Rook") == 0) || (EOSkakiera[(finishColumn - 1), (finishRank - 1)].CompareTo("White Knight") == 0) || (EOSkakiera[(finishColumn - 1), (finishRank - 1)].CompareTo("White Bishop") == 0) || (EOSkakiera[(finishColumn - 1), (finishRank - 1)].CompareTo("White Queen") == 0)))
                                    Orthotita = true;
                            }
                            else if (checkForDanger == 1)
                            {

                                if ((finishRank == (startRank - 1)) && (finishColumn == (startColumn + 1)))
                                    Orthotita = true;


                                if ((finishRank == (startRank - 1)) && (finishColumn == (startColumn - 1)))
                                    Orthotita = true;
                            }
                        }


                        else if ((finishRank == (startRank - 1)) && (finishColumn == (startColumn + 1)))
                        {
                            if (checkForDanger == 0)
                            {
                                if ((finishRank == 3) && (EOSkakiera[(finishColumn - 1), (3)].CompareTo("White Pawn") == 0))
                                {
                                    Orthotita = true;
                                    enpassant_occured = true;
                                    EOSkakiera[(finishColumn - 1), (finishRank + 1 - 1)] = "";
                                }
                                else
                                {
                                    Orthotita = false;
                                    enpassant_occured = false;
                                }
                            }
                        }

                        else if ((finishRank == (startRank - 1)) && (finishColumn == (startColumn - 1)))
                        {
                            if (checkForDanger == 0)
                            {
                                if ((finishRank == 3) && (EOSkakiera[(finishColumn - 1), (3)].CompareTo("White Pawn") == 0))
                                {
                                    Orthotita = true;
                                    enpassant_occured = true;
                                    EOSkakiera[(finishColumn - 1), (finishRank + 1 - 1)] = "";
                                }
                                else
                                {
                                    Orthotita = false;
                                    enpassant_occured = false;
                                }
                            }
                        }

                    }

                }
                return Orthotita;
            }

            public static void Enter_move()
            {


                if (m_StartingColumn.CompareTo("A") == 0)
                    numeroColumnaInicial = 1;
                else if (m_StartingColumn.CompareTo("B") == 0)
                    numeroColumnaInicial = 2;
                else if (m_StartingColumn.CompareTo("C") == 0)
                    numeroColumnaInicial = 3;
                else if (m_StartingColumn.CompareTo("D") == 0)
                    numeroColumnaInicial = 4;
                else if (m_StartingColumn.CompareTo("E") == 0)
                    numeroColumnaInicial = 5;
                else if (m_StartingColumn.CompareTo("F") == 0)
                    numeroColumnaInicial = 6;
                else if (m_StartingColumn.CompareTo("G") == 0)
                    numeroColumnaInicial = 7;
                else if (m_StartingColumn.CompareTo("H") == 0)
                    numeroColumnaInicial = 8;


                if (m_FinishingColumn.CompareTo("A") == 0)
                    columnaFinaliza = 1;
                else if (m_FinishingColumn.CompareTo("B") == 0)
                    columnaFinaliza = 2;
                else if (m_FinishingColumn.CompareTo("C") == 0)
                    columnaFinaliza = 3;
                else if (m_FinishingColumn.CompareTo("D") == 0)
                    columnaFinaliza = 4;
                else if (m_FinishingColumn.CompareTo("E") == 0)
                    columnaFinaliza = 5;
                else if (m_FinishingColumn.CompareTo("F") == 0)
                    columnaFinaliza = 6;
                else if (m_FinishingColumn.CompareTo("G") == 0)
                    columnaFinaliza = 7;
                else if (m_FinishingColumn.CompareTo("H") == 0)
                    columnaFinaliza = 8;


                if (ActualJugando.CompareTo("HY") == 0)
                    Console.WriteLine("Not your turn");

                if (((ActualJugando.CompareTo("Human") == 0)) && (((colorJugando.CompareTo("White") == 0) && ((Skakiera[(numeroColumnaInicial - 1), (m_StartingRank - 1)].CompareTo("White Pawn") == 0) || (Skakiera[(numeroColumnaInicial - 1), (m_StartingRank - 1)].CompareTo("White Rook") == 0) || (Skakiera[(numeroColumnaInicial - 1), (m_StartingRank - 1)].CompareTo("White Knight") == 0) || (Skakiera[(numeroColumnaInicial - 1), (m_StartingRank - 1)].CompareTo("White Bishop") == 0) || (Skakiera[(numeroColumnaInicial - 1), (m_StartingRank - 1)].CompareTo("White Queen") == 0) || (Skakiera[(numeroColumnaInicial - 1), (m_StartingRank - 1)].CompareTo("White King") == 0))) || ((colorJugando.CompareTo("Black") == 0) && ((Skakiera[(numeroColumnaInicial - 1), (m_StartingRank - 1)].CompareTo("Black Pawn") == 0) || (Skakiera[(numeroColumnaInicial - 1), (m_StartingRank - 1)].CompareTo("Black Rook") == 0) || (Skakiera[(numeroColumnaInicial - 1), (m_StartingRank - 1)].CompareTo("Black Knight") == 0) || (Skakiera[(numeroColumnaInicial - 1), (m_StartingRank - 1)].CompareTo("Black Bishop") == 0) || (Skakiera[(numeroColumnaInicial - 1), (m_StartingRank - 1)].CompareTo("Black Queen") == 0) || (Skakiera[(numeroColumnaInicial - 1), (m_StartingRank - 1)].CompareTo("Black King") == 0)))))
                {
                    m_WrongColumn = false;
                    piezaMoviendose = Skakiera[(numeroColumnaInicial - 1), (m_StartingRank - 1)];
                }
                else
                {
                    m_WrongColumn = true;
                }

                m_OrthotitaKinisis = ElegxosOrthotitas(Skakiera, 0, m_StartingRank, numeroColumnaInicial, m_FinishingRank, columnaFinaliza, piezaMoviendose);


                if (m_OrthotitaKinisis == true)
                    m_NomimotitaKinisis = ElegxosNomimotitas(Skakiera, 0, m_StartingRank, numeroColumnaInicial, m_FinishingRank, columnaFinaliza, piezaMoviendose);

                if ((piezaMoviendose.CompareTo("White Pawn") == 0) && (m_FinishingRank == 8))
                    piezaMoviendose = "White Queen";
                if ((piezaMoviendose.CompareTo("Black Pawn") == 0) && (m_FinishingRank == 1))
                    piezaMoviendose = "Black Queen";

                if ((m_OrthotitaKinisis == true) && (m_NomimotitaKinisis == true))
                {
                    if ((piezaMoviendose.CompareTo("White Rook") == 0) || (piezaMoviendose.CompareTo("Black Rook") == 0))
                        valorPiezaMovidaHumano = 5;
                    if ((piezaMoviendose.CompareTo("White Knight") == 0) || (piezaMoviendose.CompareTo("Black Knight") == 0))
                        valorPiezaMovidaHumano = 3;
                    if ((piezaMoviendose.CompareTo("White Bishop") == 0) || (piezaMoviendose.CompareTo("Black Bishop") == 0))
                        valorPiezaMovidaHumano = 3;
                    if ((piezaMoviendose.CompareTo("White Queen") == 0) || (piezaMoviendose.CompareTo("Black Queen") == 0))
                        valorPiezaMovidaHumano = 9;
                    if ((piezaMoviendose.CompareTo("White King") == 0) || (piezaMoviendose.CompareTo("Black King") == 0))
                        valorPiezaMovidaHumano = 119;
                    if ((piezaMoviendose.CompareTo("White Pawn") == 0) || (piezaMoviendose.CompareTo("Black Pawn") == 0))
                        valorPiezaMovidaHumano = 1;

                    Skakiera[(numeroColumnaInicial - 1), (m_StartingRank - 1)] = "";

                    jugadorUltimoMovimientoColumn = -1;
                    jugadorUltimoMovimientoRow = -1;

                    if (Skakiera[(columnaFinaliza - 1), (m_FinishingRank - 1)].CompareTo("") != 0)
                    {
                        jugadorUltimoMovimientoColumn = columnaFinaliza;
                        jugadorUltimoMovimientoRow = m_FinishingRank;

                    }

                    Skakiera[(columnaFinaliza - 1), (m_FinishingRank - 1)] = piezaMoviendose;


                    if (enpassant_occured == true)
                    {
                        if (mColorJugsdor.CompareTo("White") == 0)
                            Skakiera[(columnaFinaliza - 1), (m_FinishingRank - 1 - 1)] = "";
                        else if (mColorJugsdor.CompareTo("Black") == 0)
                            Skakiera[(columnaFinaliza - 1), (m_FinishingRank - 1 + 1)] = "";
                    }


                    if ((m_StartingRank == 2) && (m_FinishingRank == 4))
                    {
                        enpassant_possible_target_rank = m_FinishingRank - 1;
                        enpassant_possible_target_column = columnaFinaliza;
                    }
                    else if ((m_StartingRank == 7) && (m_FinishingRank == 5))
                    {
                        enpassant_possible_target_rank = m_FinishingRank + 1;
                        enpassant_possible_target_column = columnaFinaliza;
                    }
                    else
                    {
                        enpassant_possible_target_rank = -9;
                        enpassant_possible_target_column = -9;
                    }



                    if (Castling_Occured == true)
                    {
                        if (mColorJugsdor.CompareTo("White") == 0)
                        {
                            if (Skakiera[(6), (0)].CompareTo("White King") == 0)
                            {
                                Skakiera[(5), (0)] = "White Rook";
                                Skakiera[(7), (0)] = "";

                            }
                            else if (Skakiera[(2), (0)].CompareTo("White King") == 0)
                            {
                                Skakiera[(3), (0)] = "White Rook";
                                Skakiera[(0), (0)] = "";

                            }
                        }
                        else if (mColorJugsdor.CompareTo("Black") == 0)
                        {
                            if (Skakiera[(6), (7)].CompareTo("Black King") == 0)
                            {
                                Skakiera[(5), (7)] = "Black Rook";
                                Skakiera[(7), (7)] = "";

                            }
                            else if (Skakiera[(2), (7)].CompareTo("Black King") == 0)
                            {
                                Skakiera[(3), (7)] = "Black Rook";
                                Skakiera[(0), (7)] = "";

                            }
                        }


                        Castling_Occured = false;
                    }

                    ActualJugando = "HY";

                    if (colorJugando.CompareTo("White") == 0)
                        colorJugando = "Black";
                    else if (colorJugando.CompareTo("Black") == 0)
                        colorJugando = "White";

                    m_StartingColumn = "";
                    m_FinishingColumn = "";
                    m_StartingRank = 1;
                    m_FinishingRank = 1;
                    if (ActualJugando.CompareTo("HY") == 0)
                    {
                        movimientoAnalizado = 0;
                        detenerAnalisis = false;
                        First_Call = true;
                        mejorMovimientoEncontrado = false;
                        quienEStaAnalizado = "HY";
                    }

                }

                else
                {
                    MessageBox.Show("Invalid move");
                }


            }

            public static void PawnPromotion()
            {
                for (i = 0; i <= 7; i++)
                {
                    if (Skakiera[(i), (0)].CompareTo("Black Pawn") == 0)
                    {

                        Skakiera[(i), (0)] = "Black Queen";
                    }

                    if (Skakiera[(i), (7)].CompareTo("White Pawn") == 0)
                    {

                        Skakiera[(i), (7)] = "White Queen";
                    }

                }
            }

            public static void Starting_position()
            {

                for (int a = 0; a <= 7; a++)
                {
                    for (int b = 0; b <= 7; b++)
                    {
                        Skakiera[(a), (b)] = "";
                    }
                }

                Skakiera[(0), (0)] = "White Rook";
                Skakiera[(0), (1)] = "White Pawn";
                Skakiera[(0), (6)] = "Black Pawn";
                Skakiera[(0), (7)] = "Black Rook";
                Skakiera[(1), (0)] = "White Knight";
                Skakiera[(1), (1)] = "White Pawn";
                Skakiera[(1), (6)] = "Black Pawn";
                Skakiera[(1), (7)] = "Black Knight";
                Skakiera[(2), (0)] = "White Bishop";
                Skakiera[(2), (1)] = "White Pawn";
                Skakiera[(2), (6)] = "Black Pawn";
                Skakiera[(2), (7)] = "Black Bishop";
                Skakiera[(3), (0)] = "White Queen";
                Skakiera[(3), (1)] = "White Pawn";
                Skakiera[(3), (6)] = "Black Pawn";
                Skakiera[(3), (7)] = "Black Queen";
                Skakiera[(4), (0)] = "White King";
                Skakiera[(4), (1)] = "White Pawn";
                Skakiera[(4), (6)] = "Black Pawn";
                Skakiera[(4), (7)] = "Black King";
                Skakiera[(5), (0)] = "White Bishop";
                Skakiera[(5), (1)] = "White Pawn";
                Skakiera[(5), (6)] = "Black Pawn";
                Skakiera[(5), (7)] = "Black Bishop";
                Skakiera[(6), (0)] = "White Knight";
                Skakiera[(6), (1)] = "White Pawn";
                Skakiera[(6), (6)] = "Black Pawn";
                Skakiera[(6), (7)] = "Black Knight";
                Skakiera[(7), (0)] = "White Rook";
                Skakiera[(7), (1)] = "White Pawn";
                Skakiera[(7), (6)] = "Black Pawn";
                Skakiera[(7), (7)] = "Black Rook";


                colorJugando = "White";
            }

            public static void Analizar1MovimientoHumano(string[,] Skakiera_Human_Thinking_2)
            {

                if (activateLogs == true)
                {
                    ajedrez_sw1.WriteLine("");
                    ajedrez_sw1.WriteLine("HMT2 -- Entered Analyze_Move_1_HumanMove");
                    ajedrez_sw1.WriteLine(string.Concat("HMT2 -- Depth analyzed: ", movimientoAnalizado.ToString()));
                    ajedrez_sw1.WriteLine(string.Concat("HMT2 -- Number of moves analyzed: ", numeroMovimientosAnalizados.ToString()));
                    ajedrez_sw1.WriteLine(string.Concat("HMT2 -- Move analyzed: ", m_StartingColumnNumber_HY.ToString(), m_StartingRank_HY.ToString(), " -> ", m_FinishingColumnNumber_HY.ToString(), m_FinishingRank_HY.ToString()));
                    ajedrez_sw1.WriteLine(string.Concat("HMT2 -- Number of Nodes 0: ", cantidadNodoNivel0.ToString()));
                    ajedrez_sw1.WriteLine(string.Concat("HMT2 -- Number of Nodes 1: ", cantidadNodoNivel1.ToString()));
                    ajedrez_sw1.WriteLine(string.Concat("HMT2 -- Number of Nodes 2: ", cantidadNodoNivel2.ToString()));




                    for (i = 0; i <= 7; i++)
                    {
                        for (j = 0; j <= 7; j++)
                        {
                            switch (Skakiera_Human_Thinking_2[(i), (j)])
                            {
                                case "White Rook":
                                    NodesAnalysis1_Chessboard_before[i, j, cantidadNodoNivel1] = "WR";
                                    break;

                                case "White Knight":
                                    NodesAnalysis1_Chessboard_before[i, j, cantidadNodoNivel1] = "WN";
                                    break;

                                case "White Bishop":
                                    NodesAnalysis1_Chessboard_before[i, j, cantidadNodoNivel1] = "WB";
                                    break;

                                case "White Queen":
                                    NodesAnalysis1_Chessboard_before[i, j, cantidadNodoNivel1] = "WQ";
                                    break;

                                case "White King":
                                    NodesAnalysis1_Chessboard_before[i, j, cantidadNodoNivel1] = "WK";
                                    break;

                                case "White Pawn":
                                    NodesAnalysis1_Chessboard_before[i, j, cantidadNodoNivel1] = "WP";
                                    break;

                                case "Black Rook":
                                    NodesAnalysis1_Chessboard_before[i, j, cantidadNodoNivel1] = "BR";
                                    break;

                                case "Black Knight":
                                    NodesAnalysis1_Chessboard_before[i, j, cantidadNodoNivel1] = "BN";
                                    break;

                                case "Black Bishop":
                                    NodesAnalysis1_Chessboard_before[i, j, cantidadNodoNivel1] = "BB";
                                    break;

                                case "Black Queen":
                                    NodesAnalysis1_Chessboard_before[i, j, cantidadNodoNivel1] = "BQ";
                                    break;

                                case "Black King":
                                    NodesAnalysis1_Chessboard_before[i, j, cantidadNodoNivel1] = "BK";
                                    break;

                                case "Black Pawn":
                                    NodesAnalysis1_Chessboard_before[i, j, cantidadNodoNivel1] = "BP";
                                    break;

                                case "":
                                    NodesAnalysis1_Chessboard_before[i, j, cantidadNodoNivel1] = "  ";
                                    break;
                            }
                        }
                    }

                    ajedrez_sw1.WriteLine("");
                    ajedrez_sw1.WriteLine("CHESSBOARD Move 1 (upon calling function)");
                    ajedrez_sw1.WriteLine("-----------------------------------------");
                    for (int yj = 7; yj >= 0; yj--)
                    {
                        ajedrez_sw1.WriteLine(String.Concat("| ", NodesAnalysis1_Chessboard_before[0, yj, cantidadNodoNivel1], " | ", NodesAnalysis1_Chessboard_before[1, yj, cantidadNodoNivel1], " | ", NodesAnalysis1_Chessboard_before[2, yj, cantidadNodoNivel1], " | ", NodesAnalysis1_Chessboard_before[3, yj, cantidadNodoNivel1], " | ", NodesAnalysis1_Chessboard_before[4, yj, cantidadNodoNivel1], " | ", NodesAnalysis1_Chessboard_before[5, yj, cantidadNodoNivel1], " | ", NodesAnalysis1_Chessboard_before[6, yj, cantidadNodoNivel1], " | ", NodesAnalysis1_Chessboard_before[7, yj, cantidadNodoNivel1], " |"));
                        ajedrez_sw1.WriteLine("-----------------------------------------");
                    }
                    ajedrez_sw1.WriteLine("CHESSBOARD Move 1 - END");
                    ajedrez_sw1.WriteLine("");

                }


                int bestScoreLevel1 = 0;


                int skakos1 = 0;
                int trelos35 = 0;
                String MovingPiece1 = "";
                String ProsorinoKommati1 = "";
                int m_StartingColumnNumber1 = 0;
                int m_FinishingColumnNumber1 = 0;
                int m_StartingRank1 = 0;
                int m_FinishingRank1 = 0;

                MovimientoJugadorEncontradod = false;

                for (skakos1 = 0; skakos1 <= 7; skakos1++)
                {
                    for (trelos35 = 0; trelos35 <= 7; trelos35++)
                    {
                        if (((quienEStaAnalizado.CompareTo("Human") == 0) && ((((Skakiera_Human_Thinking_2[(skakos1), (trelos35)].CompareTo("Black King") == 0) || (Skakiera_Human_Thinking_2[(skakos1), (trelos35)].CompareTo("Black Queen") == 0) || (Skakiera_Human_Thinking_2[(skakos1), (trelos35)].CompareTo("Black Rook") == 0) || (Skakiera_Human_Thinking_2[(skakos1), (trelos35)].CompareTo("Black Knight") == 0) || (Skakiera_Human_Thinking_2[(skakos1), (trelos35)].CompareTo("Black Bishop") == 0) || (Skakiera_Human_Thinking_2[(skakos1), (trelos35)].CompareTo("Black Pawn") == 0)) && (mColorJugsdor.CompareTo("Black") == 0)) || (((Skakiera_Human_Thinking_2[(skakos1), (trelos35)].CompareTo("White King") == 0) || (Skakiera_Human_Thinking_2[(skakos1), (trelos35)].CompareTo("White Queen") == 0) || (Skakiera_Human_Thinking_2[(skakos1), (trelos35)].CompareTo("White Rook") == 0) || (Skakiera_Human_Thinking_2[(skakos1), (trelos35)].CompareTo("White Knight") == 0) || (Skakiera_Human_Thinking_2[(skakos1), (trelos35)].CompareTo("White Bishop") == 0) || (Skakiera_Human_Thinking_2[(skakos1), (trelos35)].CompareTo("White Pawn") == 0)) && (mColorJugsdor.CompareTo("White") == 0)))))
                        {
                            for (int w = 0; w <= 7; w++)
                            {
                                for (int r = 0; r <= 7; r++)
                                {
                                    MovingPiece1 = Skakiera_Human_Thinking_2[(skakos1), (trelos35)];
                                    m_StartingColumnNumber1 = skakos1 + 1;
                                    m_FinishingColumnNumber1 = w + 1;
                                    m_StartingRank1 = trelos35 + 1;
                                    m_FinishingRank1 = r + 1;


                                    iniciarColumn1libre = m_StartingColumnNumber1;
                                    m_FinishingColumnNumber1_public = m_FinishingColumnNumber1;
                                    puntaje1Inicial = m_StartingRank1;
                                    m_FinishingRank1_public = m_FinishingRank1;

                                    ProsorinoKommati1 = Skakiera_Human_Thinking_2[(m_FinishingColumnNumber1 - 1), (m_FinishingRank1 - 1)];
                                    numeroMovimientosAnalizados++;
                                    ActualJugando = "Human";
                                    m_WrongColumn = false;
                                    m_OrthotitaKinisis = ElegxosOrthotitas(Skakiera_Human_Thinking_2, 0, m_StartingRank1, m_StartingColumnNumber1, m_FinishingRank1, m_FinishingColumnNumber1, MovingPiece1);
                                    m_NomimotitaKinisis = ElegxosNomimotitas(Skakiera_Human_Thinking_2, 0, m_StartingRank1, m_StartingColumnNumber1, m_FinishingRank1, m_FinishingColumnNumber1, MovingPiece1);
                                    ActualJugando = "HY";


                                    if ((m_OrthotitaKinisis == true) && (m_NomimotitaKinisis == true))
                                    {

                                        MovimientoJugadorEncontradod = true;



                                        String m_StartingColumnNumber1_moveText;
                                        String m_FinishingColumnNumber1_moveText;

                                        switch (m_StartingColumnNumber1)
                                        {
                                            case (1):
                                                m_StartingColumnNumber1_moveText = "a";
                                                break;

                                            case (2):
                                                m_StartingColumnNumber1_moveText = "b";
                                                break;

                                            case (3):
                                                m_StartingColumnNumber1_moveText = "c";
                                                break;

                                            case (4):
                                                m_StartingColumnNumber1_moveText = "d";
                                                break;

                                            case (5):
                                                m_StartingColumnNumber1_moveText = "e";
                                                break;

                                            case (6):
                                                m_StartingColumnNumber1_moveText = "f";
                                                break;

                                            case (7):
                                                m_StartingColumnNumber1_moveText = "g";
                                                break;

                                            case (8):
                                                m_StartingColumnNumber1_moveText = "h";
                                                break;

                                            default:
                                                m_StartingColumnNumber1_moveText = "Error";
                                                break;
                                        }

                                        switch (m_FinishingColumnNumber1)
                                        {
                                            case (1):
                                                m_FinishingColumnNumber1_moveText = "a";
                                                break;

                                            case (2):
                                                m_FinishingColumnNumber1_moveText = "b";
                                                break;

                                            case (3):
                                                m_FinishingColumnNumber1_moveText = "c";
                                                break;

                                            case (4):
                                                m_FinishingColumnNumber1_moveText = "d";
                                                break;

                                            case (5):
                                                m_FinishingColumnNumber1_moveText = "e";
                                                break;

                                            case (6):
                                                m_FinishingColumnNumber1_moveText = "f";
                                                break;

                                            case (7):
                                                m_FinishingColumnNumber1_moveText = "g";
                                                break;

                                            case (8):
                                                m_FinishingColumnNumber1_moveText = "h";
                                                break;

                                            default:
                                                m_FinishingColumnNumber1_moveText = "Error";
                                                break;
                                        }

                                        Movimiento1 = String.Concat(m_StartingColumnNumber1_moveText,
                                                                   m_StartingRank1.ToString(), " -> ",
                                                                   m_FinishingColumnNumber1_moveText,
                                                                   m_FinishingRank1.ToString());

                                        Analisis1Nodo_Text[cantidadNodoNivel1] = Movimiento1;



                                        ProsorinoKommati1 = Skakiera_Human_Thinking_2[(m_FinishingColumnNumber1 - 1), (m_FinishingRank1 - 1)];
                                        Skakiera_Human_Thinking_2[(m_StartingColumnNumber1 - 1), (m_StartingRank1 - 1)] = "";
                                        Skakiera_Human_Thinking_2[(m_FinishingColumnNumber1 - 1), (m_FinishingRank1 - 1)] = MovingPiece1;

                                        temporalPuntajeMovimiento1Jugador = contarPuntaje(Skakiera_Human_Thinking_2);
                                        analisisNodo1[cantidadNodoNivel1, 0] = temporalPuntajeMovimiento1Jugador;
                                        analisisNodo1[cantidadNodoNivel1, 1] = cantidadNodoNivel0;




                                        if (movimientoAnalizado < revisarProfundo)
                                        {

                                            movimientoAnalizado = movimientoAnalizado + 1;

                                            quienEStaAnalizado = "HY";


                                            String[,] Skakiera_Move_After_1_new = new String[8, 8];

                                            for (i = 0; i <= 7; i++)
                                            {
                                                for (j = 0; j <= 7; j++)
                                                {
                                                    Skakiera_Move_After_1_new[(i), (j)] = Skakiera_Human_Thinking_2[(i), (j)];
                                                }
                                            }

                                            if (movimientoAnalizado == 2)
                                                Analizar2MovimientoComputadora(Skakiera_Move_After_1_new);
                                        }

                                        Skakiera_Human_Thinking_2[(m_StartingColumnNumber1 - 1), (m_StartingRank1 - 1)] = MovingPiece1;
                                        Skakiera_Human_Thinking_2[(m_FinishingColumnNumber1 - 1), (m_FinishingRank1 - 1)] = ProsorinoKommati1;

                                        cantidadNodoNivel1++;
                                        totalNodos++;
                                    }

                                }
                            }

                        }

                    }
                }

                if (MovimientoJugadorEncontradod == false)
                {

                    if (mColorJugsdor.CompareTo("White") == 0)
                    {
                        chequeoReyBlanco = chequeoBlanca(Skakiera_Human_Thinking_2);
                    }
                    else if (mColorJugsdor.CompareTo("Black") == 0)
                    {
                        BlackKingCheck = ChequeoNegro(Skakiera_Human_Thinking_2);
                    }
                    if ((mColorJugsdor.CompareTo("White") == 0) && (chequeoReyBlanco == true))
                    {
                        Mate_Found = true;
                        m_ColumnaNumeroInicial_mate = m_StartingColumnNumber_HY;
                        m_ColumnaNumeroFinal_mate = m_FinishingColumnNumber_HY;
                        m_RankingInicial_mate = m_StartingRank_HY;
                        m_RankFinal_mate = m_FinishingRank_HY;
                    }

                    if ((mColorJugsdor.CompareTo("White") == 0) && (chequeoReyBlanco == false))
                    {
                        PatEncontrado = true;
                    }
                    if ((mColorJugsdor.CompareTo("Black") == 0) && (BlackKingCheck == true))
                    {
                        Mate_Found = true;
                        m_ColumnaNumeroInicial_mate = m_StartingColumnNumber_HY;
                        m_ColumnaNumeroFinal_mate = m_FinishingColumnNumber_HY;
                        m_RankingInicial_mate = m_StartingRank_HY;
                        m_RankFinal_mate = m_FinishingRank_HY;
                    }

                    if ((mColorJugsdor.CompareTo("Black") == 0) && (BlackKingCheck == false))
                    {

                        PatEncontrado = true;
                    }
                }

                movimientoAnalizado = movimientoAnalizado - 1;
                quienEStaAnalizado = "HY";
            }

            public static void Analizar3MovimientoHumano(string[,] Skakiera_Human_Thinking_3)
            {

                int bestScoreLevel3 = 0;

                int skakos3 = 0;
                int trelos35 = 0;
                String MovingPiece3 = "";
                String ProsorinoKommati3 = "";
                int m_StartingColumnNumber3 = 0;
                int m_FinishingColumnNumber3 = 0;
                int m_StartingRank3 = 0;
                int m_FinishingRank3 = 0;

                String[,] Skakiera_Move_After_3 = new String[8, 8];


                for (skakos3 = 0; skakos3 <= 7; skakos3++)
                {
                    for (trelos35 = 0; trelos35 <= 7; trelos35++)
                    {

                        if (((quienEStaAnalizado.CompareTo("Human") == 0) && ((((Skakiera_Human_Thinking_3[(skakos3), (trelos35)].CompareTo("Black King") == 0) || (Skakiera_Human_Thinking_3[(skakos3), (trelos35)].CompareTo("Black Queen") == 0) || (Skakiera_Human_Thinking_3[(skakos3), (trelos35)].CompareTo("Black Rook") == 0) || (Skakiera_Human_Thinking_3[(skakos3), (trelos35)].CompareTo("Black Knight") == 0) || (Skakiera_Human_Thinking_3[(skakos3), (trelos35)].CompareTo("Black Bishop") == 0) || (Skakiera_Human_Thinking_3[(skakos3), (trelos35)].CompareTo("Black Pawn") == 0)) && (mColorJugsdor.CompareTo("Black") == 0)) || (((Skakiera_Human_Thinking_3[(skakos3), (trelos35)].CompareTo("White King") == 0) || (Skakiera_Human_Thinking_3[(skakos3), (trelos35)].CompareTo("White Queen") == 0) || (Skakiera_Human_Thinking_3[(skakos3), (trelos35)].CompareTo("White Rook") == 0) || (Skakiera_Human_Thinking_3[(skakos3), (trelos35)].CompareTo("White Knight") == 0) || (Skakiera_Human_Thinking_3[(skakos3), (trelos35)].CompareTo("White Bishop") == 0) || (Skakiera_Human_Thinking_3[(skakos3), (trelos35)].CompareTo("White Pawn") == 0)) && (mColorJugsdor.CompareTo("White") == 0)))))
                        {
                            for (int w = 0; w <= 7; w++)
                            {
                                for (int r = 0; r <= 7; r++)
                                {
                                    MovingPiece3 = Skakiera_Human_Thinking_3[(skakos3), (trelos35)];
                                    m_StartingColumnNumber3 = skakos3 + 1;
                                    m_FinishingColumnNumber3 = w + 1;
                                    m_StartingRank3 = trelos35 + 1;
                                    m_FinishingRank3 = r + 1;
                                    ProsorinoKommati3 = Skakiera_Human_Thinking_3[(m_FinishingColumnNumber3 - 1), (m_FinishingRank3 - 1)];

                                    numeroMovimientosAnalizados++;


                                    ActualJugando = "Human";
                                    m_WrongColumn = false;
                                    m_OrthotitaKinisis = ElegxosOrthotitas(Skakiera_Human_Thinking_3, 0, m_StartingRank3, m_StartingColumnNumber3, m_FinishingRank3, m_FinishingColumnNumber3, MovingPiece3);
                                    m_NomimotitaKinisis = ElegxosNomimotitas(Skakiera_Human_Thinking_3, 0, m_StartingRank3, m_StartingColumnNumber3, m_FinishingRank3, m_FinishingColumnNumber3, MovingPiece3);

                                    ActualJugando = "HY";


                                    if ((m_OrthotitaKinisis == true) && (m_NomimotitaKinisis == true))
                                    {

                                        String m_StartingColumnNumber3_moveText;
                                        String m_FinishingColumnNumber3_moveText;

                                        switch (m_StartingColumnNumber3)
                                        {
                                            case (1):
                                                m_StartingColumnNumber3_moveText = "a";
                                                break;

                                            case (2):
                                                m_StartingColumnNumber3_moveText = "b";
                                                break;

                                            case (3):
                                                m_StartingColumnNumber3_moveText = "c";
                                                break;

                                            case (4):
                                                m_StartingColumnNumber3_moveText = "d";
                                                break;

                                            case (5):
                                                m_StartingColumnNumber3_moveText = "e";
                                                break;

                                            case (6):
                                                m_StartingColumnNumber3_moveText = "f";
                                                break;

                                            case (7):
                                                m_StartingColumnNumber3_moveText = "g";
                                                break;

                                            case (8):
                                                m_StartingColumnNumber3_moveText = "h";
                                                break;

                                            default:
                                                m_StartingColumnNumber3_moveText = "Error";
                                                break;
                                        }

                                        switch (m_FinishingColumnNumber3)
                                        {
                                            case (1):
                                                m_FinishingColumnNumber3_moveText = "a";
                                                break;

                                            case (2):
                                                m_FinishingColumnNumber3_moveText = "b";
                                                break;

                                            case (3):
                                                m_FinishingColumnNumber3_moveText = "c";
                                                break;

                                            case (4):
                                                m_FinishingColumnNumber3_moveText = "d";
                                                break;

                                            case (5):
                                                m_FinishingColumnNumber3_moveText = "e";
                                                break;

                                            case (6):
                                                m_FinishingColumnNumber3_moveText = "f";
                                                break;

                                            case (7):
                                                m_FinishingColumnNumber3_moveText = "g";
                                                break;

                                            case (8):
                                                m_FinishingColumnNumber3_moveText = "h";
                                                break;

                                            default:
                                                m_FinishingColumnNumber3_moveText = "Error";
                                                break;
                                        }

                                        Movimiento3 = String.Concat(m_StartingColumnNumber3_moveText,
                                                                   m_StartingRank3.ToString(), " -> ",
                                                                   m_FinishingColumnNumber3_moveText,
                                                                   m_FinishingRank3.ToString());


                                        Analisis3Nodo_Text[cantidadNodoNivel3] = Movimiento3;


                                        Skakiera_Human_Thinking_3[(m_StartingColumnNumber3 - 1), (m_StartingRank3 - 1)] = "";
                                        Skakiera_Human_Thinking_3[(m_FinishingColumnNumber3 - 1), (m_FinishingRank3 - 1)] = MovingPiece3;

                                        temporalPuntajeMovimiento3Humano = contarPuntaje(Skakiera_Human_Thinking_3);
                                        analisisNodo03[cantidadNodoNivel3, 0] = temporalPuntajeMovimiento3Humano;

                                        analisisNodo03[cantidadNodoNivel3, 1] = cantidadNodoNivel2;



                                        if ((movimientoAnalizado < revisarProfundo) && (ProsorinoKommati3.CompareTo("") == 1))
                                        {
                                            movimientoAnalizado = movimientoAnalizado + 1;
                                            bestScoreLevel3 = temporalPuntajeMovimiento3Humano;

                                            quienEStaAnalizado = "HY";

                                            String[,] Skakiera_Move_After_3_new = new String[8, 8];

                                            for (i = 0; i <= 7; i++)
                                            {
                                                for (j = 0; j <= 7; j++)
                                                {
                                                    Skakiera_Move_After_3[(i), (j)] = Skakiera_Human_Thinking_3[(i), (j)];
                                                    Skakiera_Move_After_3_new[(i), (j)] = Skakiera_Human_Thinking_3[(i), (j)];
                                                }
                                            }

                                            if (movimientoAnalizado == 2)
                                                Analizar2MovimientoComputadora(Skakiera_Move_After_3_new);
                                            else if (movimientoAnalizado == 4)
                                                AnalizarMovimiento4InteligenciaArtificial(Skakiera_Move_After_3_new);
                                        }


                                        Skakiera_Human_Thinking_3[(m_StartingColumnNumber3 - 1), (m_StartingRank3 - 1)] = MovingPiece3;
                                        Skakiera_Human_Thinking_3[(m_FinishingColumnNumber3 - 1), (m_FinishingRank3 - 1)] = ProsorinoKommati3;
                                        cantidadNodoNivel3++;
                                        totalNodos++;

                                    }

                                }
                            }

                        }

                    }
                }

                movimientoAnalizado = movimientoAnalizado - 1;
                quienEStaAnalizado = "HY";
            }

            public static void Analizar2MovimientoComputadora(string[,] Skakiera_Thinking_HY_2)
            {

                if (activateLogs == true)
                {
                    ajedrez_sw1.WriteLine("");
                    ajedrez_sw1.WriteLine("CMT2 -- Entered Analyze_Move_2_ComputerMove");
                    ajedrez_sw1.WriteLine(string.Concat("CMT2 -- Depth analyzed: ", movimientoAnalizado.ToString()));
                    ajedrez_sw1.WriteLine(string.Concat("CMT2 -- Number of Nodes 0: ", cantidadNodoNivel0.ToString()));
                    ajedrez_sw1.WriteLine(string.Concat("CMT2 -- Number of Nodes 1: ", cantidadNodoNivel1.ToString()));
                    ajedrez_sw1.WriteLine(string.Concat("CMT2 -- Number of Nodes 2: ", cantidadNodoNivel2.ToString()));


                    for (i = 0; i <= 7; i++)
                    {
                        for (j = 0; j <= 7; j++)
                        {
                            switch (Skakiera_Thinking_HY_2[(i), (j)])
                            {
                                case "White Rook":
                                    NodesAnalysis2_Chessboard_before[i, j, cantidadNodoNivel2] = "WR";
                                    break;

                                case "White Knight":
                                    NodesAnalysis2_Chessboard_before[i, j, cantidadNodoNivel2] = "WN";
                                    break;

                                case "White Bishop":
                                    NodesAnalysis2_Chessboard_before[i, j, cantidadNodoNivel2] = "WB";
                                    break;

                                case "White Queen":
                                    NodesAnalysis2_Chessboard_before[i, j, cantidadNodoNivel2] = "WQ";
                                    break;

                                case "White King":
                                    NodesAnalysis2_Chessboard_before[i, j, cantidadNodoNivel2] = "WK";
                                    break;

                                case "White Pawn":
                                    NodesAnalysis2_Chessboard_before[i, j, cantidadNodoNivel2] = "WP";
                                    break;

                                case "Black Rook":
                                    NodesAnalysis2_Chessboard_before[i, j, cantidadNodoNivel2] = "BR";
                                    break;

                                case "Black Knight":
                                    NodesAnalysis2_Chessboard_before[i, j, cantidadNodoNivel2] = "BN";
                                    break;

                                case "Black Bishop":
                                    NodesAnalysis2_Chessboard_before[i, j, cantidadNodoNivel2] = "BB";
                                    break;

                                case "Black Queen":
                                    NodesAnalysis2_Chessboard_before[i, j, cantidadNodoNivel2] = "BQ";
                                    break;

                                case "Black King":
                                    NodesAnalysis2_Chessboard_before[i, j, cantidadNodoNivel2] = "BK";
                                    break;

                                case "Black Pawn":
                                    NodesAnalysis2_Chessboard_before[i, j, cantidadNodoNivel2] = "BP";
                                    break;

                                case "":
                                    NodesAnalysis2_Chessboard_before[i, j, cantidadNodoNivel2] = "  ";
                                    break;
                            }
                        }
                    }

                    ajedrez_sw1.WriteLine("");
                    ajedrez_sw1.WriteLine("CHESSBOARD Move 2 (upon calling function)");
                    ajedrez_sw1.WriteLine("-----------------------------------------");
                    for (int yj = 7; yj >= 0; yj--)
                    {
                        ajedrez_sw1.WriteLine(String.Concat("| ", NodesAnalysis2_Chessboard_before[0, yj, cantidadNodoNivel2], " | ", NodesAnalysis2_Chessboard_before[1, yj, cantidadNodoNivel2], " | ", NodesAnalysis2_Chessboard_before[2, yj, cantidadNodoNivel2], " | ", NodesAnalysis2_Chessboard_before[3, yj, cantidadNodoNivel2], " | ", NodesAnalysis2_Chessboard_before[4, yj, cantidadNodoNivel2], " | ", NodesAnalysis2_Chessboard_before[5, yj, cantidadNodoNivel2], " | ", NodesAnalysis2_Chessboard_before[6, yj, cantidadNodoNivel2], " | ", NodesAnalysis2_Chessboard_before[7, yj, cantidadNodoNivel2], " |"));
                        ajedrez_sw1.WriteLine("-----------------------------------------");
                    }
                    ajedrez_sw1.WriteLine("CHESSBOARD Move 2 - END");
                    ajedrez_sw1.WriteLine("");

                    ajedrez_sw1.WriteLine(string.Concat("CMT2 -- Number of Nodes 3: ", cantidadNodoNivel3.ToString()));
                    ajedrez_sw1.WriteLine(string.Concat("CMT2 -- Number of Nodes 4: ", cantidadNodoNivel4.ToString()));
                    ajedrez_sw1.WriteLine(string.Concat("CMT2 -- Number of Nodes 5: ", cantidadNodoNivel5.ToString()));
                    ajedrez_sw1.WriteLine(string.Concat("CMT2 -- Number of Nodes 6: ", cantidadNodoNivel6.ToString()));
                    ajedrez_sw1.WriteLine("");
                }


                int bestScoreLevel2 = 0;
                int iii2 = 0;
                int jjj2 = 0;
                String MovingPiece2 = "";
                String ProsorinoKommati2 = "";
                int m_StartingColumnNumber2 = 0;
                int m_FinishingColumnNumber2 = 0;
                int m_StartingRank2 = 0;
                int m_FinishingRank2 = 0;

                String[,] Skakiera_Move_After_2 = new String[8, 8];


                for (iii2 = 0; iii2 <= 7; iii2++)
                {
                    for (jjj2 = 0; jjj2 <= 7; jjj2++)
                    {

                        if (((quienEStaAnalizado.CompareTo("HY") == 0) && ((((Skakiera_Thinking_HY_2[(iii2), (jjj2)].CompareTo("White King") == 0) || (Skakiera_Thinking_HY_2[(iii2), (jjj2)].CompareTo("White Queen") == 0) || (Skakiera_Thinking_HY_2[(iii2), (jjj2)].CompareTo("White Rook") == 0) || (Skakiera_Thinking_HY_2[(iii2), (jjj2)].CompareTo("White Knight") == 0) || (Skakiera_Thinking_HY_2[(iii2), (jjj2)].CompareTo("White Bishop") == 0) || (Skakiera_Thinking_HY_2[(iii2), (jjj2)].CompareTo("White Pawn") == 0)) && (mColorJugsdor.CompareTo("Black") == 0)) || (((Skakiera_Thinking_HY_2[(iii2), (jjj2)].CompareTo("Black King") == 0) || (Skakiera_Thinking_HY_2[(iii2), (jjj2)].CompareTo("Black Queen") == 0) || (Skakiera_Thinking_HY_2[(iii2), (jjj2)].CompareTo("Black Rook") == 0) || (Skakiera_Thinking_HY_2[(iii2), (jjj2)].CompareTo("Black Knight") == 0) || (Skakiera_Thinking_HY_2[(iii2), (jjj2)].CompareTo("Black Bishop") == 0) || (Skakiera_Thinking_HY_2[(iii2), (jjj2)].CompareTo("Black Pawn") == 0)) && (mColorJugsdor.CompareTo("White") == 0)))))
                        {
                            for (int w = 0; w <= 7; w++)
                            {
                                for (int r = 0; r <= 7; r++)
                                {
                                    MovingPiece2 = Skakiera_Thinking_HY_2[(iii2), (jjj2)];
                                    m_StartingColumnNumber2 = iii2 + 1;
                                    m_FinishingColumnNumber2 = w + 1;
                                    m_StartingRank2 = jjj2 + 1;
                                    m_FinishingRank2 = r + 1;
                                    ProsorinoKommati2 = Skakiera_Thinking_HY_2[(m_FinishingColumnNumber2 - 1), (m_FinishingRank2 - 1)];

                                    m_StartingColumnNumber2_public = m_StartingColumnNumber2;
                                    m_FinishingColumnNumber2_public = m_FinishingColumnNumber2;
                                    m_StartingRank2_public = m_StartingRank2;
                                    m_FinishingRank2_public = m_FinishingRank2;
                                    ActualJugando = "Human";
                                    m_WrongColumn = false;

                                    m_OrthotitaKinisis = ElegxosOrthotitas(Skakiera_Thinking_HY_2, 0, m_StartingRank2, m_StartingColumnNumber2, m_FinishingRank2, m_FinishingColumnNumber2, MovingPiece2);
                                    m_NomimotitaKinisis = ElegxosNomimotitas(Skakiera_Thinking_HY_2, 0, m_StartingRank2, m_StartingColumnNumber2, m_FinishingRank2, m_FinishingColumnNumber2, MovingPiece2);
                                    ActualJugando = "HY";


                                    if ((m_OrthotitaKinisis == true) && (m_NomimotitaKinisis == true))
                                    {

                                        String m_StartingColumnNumber2_moveText;
                                        String m_FinishingColumnNumber2_moveText;

                                        switch (m_StartingColumnNumber2)
                                        {
                                            case (1):
                                                m_StartingColumnNumber2_moveText = "a";
                                                break;

                                            case (2):
                                                m_StartingColumnNumber2_moveText = "b";
                                                break;

                                            case (3):
                                                m_StartingColumnNumber2_moveText = "c";
                                                break;

                                            case (4):
                                                m_StartingColumnNumber2_moveText = "d";
                                                break;

                                            case (5):
                                                m_StartingColumnNumber2_moveText = "e";
                                                break;

                                            case (6):
                                                m_StartingColumnNumber2_moveText = "f";
                                                break;

                                            case (7):
                                                m_StartingColumnNumber2_moveText = "g";
                                                break;

                                            case (8):
                                                m_StartingColumnNumber2_moveText = "h";
                                                break;

                                            default:
                                                m_StartingColumnNumber2_moveText = "Error";
                                                break;
                                        }

                                        switch (m_FinishingColumnNumber2)
                                        {
                                            case (1):
                                                m_FinishingColumnNumber2_moveText = "a";
                                                break;

                                            case (2):
                                                m_FinishingColumnNumber2_moveText = "b";
                                                break;

                                            case (3):
                                                m_FinishingColumnNumber2_moveText = "c";
                                                break;

                                            case (4):
                                                m_FinishingColumnNumber2_moveText = "d";
                                                break;

                                            case (5):
                                                m_FinishingColumnNumber2_moveText = "e";
                                                break;

                                            case (6):
                                                m_FinishingColumnNumber2_moveText = "f";
                                                break;

                                            case (7):
                                                m_FinishingColumnNumber2_moveText = "g";
                                                break;

                                            case (8):
                                                m_FinishingColumnNumber2_moveText = "h";
                                                break;

                                            default:
                                                m_FinishingColumnNumber2_moveText = "Error";
                                                break;
                                        }

                                        Movimiento2 = String.Concat(m_StartingColumnNumber2_moveText,
                                                                   m_StartingRank2.ToString(), " -> ",
                                                                   m_FinishingColumnNumber2_moveText,
                                                                   m_FinishingRank2.ToString());

                                        Analisis2Nodo_Text[cantidadNodoNivel2] = Movimiento2;


                                        ProsorinoKommati2 = Skakiera_Thinking_HY_2[(m_FinishingColumnNumber2 - 1), (m_FinishingRank2 - 1)];
                                        Skakiera_Thinking_HY_2[(m_StartingColumnNumber2 - 1), (m_StartingRank2 - 1)] = "";
                                        Skakiera_Thinking_HY_2[(m_FinishingColumnNumber2 - 1), (m_FinishingRank2 - 1)] = MovingPiece2;

                                        temporalPuntajeMovimiento2 = contarPuntaje(Skakiera_Thinking_HY_2);

                                        analisisNodo2[cantidadNodoNivel2, 0] = temporalPuntajeMovimiento2;
                                        analisisNodo2[cantidadNodoNivel2, 1] = cantidadNodoNivel1;





                                        if ((movimientoAnalizado < revisarProfundo) && (ProsorinoKommati2.CompareTo("") == 1))
                                        {
                                            movimientoAnalizado = movimientoAnalizado + 1;
                                            bestScoreLevel2 = temporalPuntajeMovimiento2;


                                            for (i = 0; i <= 7; i++)
                                            {
                                                for (j = 0; j <= 7; j++)
                                                {
                                                    Skakiera_Move_After_2[(i), (j)] = Skakiera_Thinking_HY_2[(i), (j)];
                                                }
                                            }

                                            quienEStaAnalizado = "Human";

                                            if (movimientoAnalizado == 1)
                                                Analizar1MovimientoHumano(Skakiera_Move_After_2);
                                            else if (movimientoAnalizado == 3)
                                                Analizar3MovimientoHumano(Skakiera_Move_After_2);
                                        }


                                        if (movimientoAnalizado == revisarProfundo)
                                        {

                                            if (activateLogs == true)
                                            {
                                                ajedrez_sw1.WriteLine("");
                                                ajedrez_sw1.WriteLine("CMT2 --------------------------------------------");
                                                ajedrez_sw1.WriteLine(string.Concat("CMT2 -- VARIANT ANALYZED : ",
                                                                    Analisis2Nodo_Text[cantidadNodoNivel2]));
                                                ajedrez_sw1.WriteLine(string.Concat("CMT2 -- FINAL SCORE REACHED : ",
                                                                    analisisNodo2[cantidadNodoNivel2, 0].ToString()));
                                                ajedrez_sw1.WriteLine("CMT2 --------------------------------------------");
                                            }







                                        }


                                        Skakiera_Thinking_HY_2[(m_StartingColumnNumber2 - 1), (m_StartingRank2 - 1)] = MovingPiece2;
                                        Skakiera_Thinking_HY_2[(m_FinishingColumnNumber2 - 1), (m_FinishingRank2 - 1)] = ProsorinoKommati2;

                                        cantidadNodoNivel2++;
                                        totalNodos++;



                                    }

                                }
                            }

                        }


                    }
                }

                movimientoAnalizado = movimientoAnalizado - 1;
                quienEStaAnalizado = "Human";
            }

            public static void AnalizarMovimiento4InteligenciaArtificial(string[,] Skakiera_Thinking_HY_4)
            {

                int bestScoreLevel4 = 0;
                int iii42 = 0;
                int jjj42 = 0;
                String MovingPiece4 = "";
                String ProsorinoKommati4 = "";
                int m_StartingColumnNumber4 = 0;
                int m_FinishingColumnNumber4 = 0;
                int m_StartingRank4 = 0;
                int m_FinishingRank4 = 0;

                String[,] Skakiera_Move_After_4 = new String[8, 8];

                for (iii42 = 0; iii42 <= 7; iii42++)
                {
                    for (jjj42 = 0; jjj42 <= 7; jjj42++)
                    {

                        if (((quienEStaAnalizado.CompareTo("HY") == 0) && ((((Skakiera_Thinking_HY_4[(iii42), (jjj42)].CompareTo("White King") == 0) || (Skakiera_Thinking_HY_4[(iii42), (jjj42)].CompareTo("White Queen") == 0) || (Skakiera_Thinking_HY_4[(iii42), (jjj42)].CompareTo("White Rook") == 0) || (Skakiera_Thinking_HY_4[(iii42), (jjj42)].CompareTo("White Knight") == 0) || (Skakiera_Thinking_HY_4[(iii42), (jjj42)].CompareTo("White Bishop") == 0) || (Skakiera_Thinking_HY_4[(iii42), (jjj42)].CompareTo("White Pawn") == 0)) && (mColorJugsdor.CompareTo("Black") == 0)) || (((Skakiera_Thinking_HY_4[(iii42), (jjj42)].CompareTo("Black King") == 0) || (Skakiera_Thinking_HY_4[(iii42), (jjj42)].CompareTo("Black Queen") == 0) || (Skakiera_Thinking_HY_4[(iii42), (jjj42)].CompareTo("Black Rook") == 0) || (Skakiera_Thinking_HY_4[(iii42), (jjj42)].CompareTo("Black Knight") == 0) || (Skakiera_Thinking_HY_4[(iii42), (jjj42)].CompareTo("Black Bishop") == 0) || (Skakiera_Thinking_HY_4[(iii42), (jjj42)].CompareTo("Black Pawn") == 0)) && (mColorJugsdor.CompareTo("White") == 0)))))
                        {

                            for (int w = 0; w <= 7; w++)
                            {
                                for (int r = 0; r <= 7; r++)
                                {
                                    MovingPiece4 = Skakiera_Thinking_HY_4[(iii42), (jjj42)];
                                    m_StartingColumnNumber4 = iii42 + 1;
                                    m_FinishingColumnNumber4 = w + 1;
                                    m_StartingRank4 = jjj42 + 1;
                                    m_FinishingRank4 = r + 1;
                                    ProsorinoKommati4 = Skakiera_Thinking_HY_4[(m_FinishingColumnNumber4 - 1), (m_FinishingRank4 - 1)];


                                    ActualJugando = "Human";
                                    m_WrongColumn = false;

                                    m_OrthotitaKinisis = ElegxosOrthotitas(Skakiera_Thinking_HY_4, 0, m_StartingRank4, m_StartingColumnNumber4, m_FinishingRank4, m_FinishingColumnNumber4, MovingPiece4);
                                    m_NomimotitaKinisis = ElegxosNomimotitas(Skakiera_Thinking_HY_4, 0, m_StartingRank4, m_StartingColumnNumber4, m_FinishingRank4, m_FinishingColumnNumber4, MovingPiece4);
                                    ActualJugando = "HY";


                                    if ((m_OrthotitaKinisis == true) && (m_NomimotitaKinisis == true))
                                    {

                                        String m_StartingColumnNumber4_moveText;
                                        String m_FinishingColumnNumber4_moveText;

                                        switch (m_StartingColumnNumber4)
                                        {
                                            case (1):
                                                m_StartingColumnNumber4_moveText = "a";
                                                break;

                                            case (2):
                                                m_StartingColumnNumber4_moveText = "b";
                                                break;

                                            case (3):
                                                m_StartingColumnNumber4_moveText = "c";
                                                break;

                                            case (4):
                                                m_StartingColumnNumber4_moveText = "d";
                                                break;

                                            case (5):
                                                m_StartingColumnNumber4_moveText = "e";
                                                break;

                                            case (6):
                                                m_StartingColumnNumber4_moveText = "f";
                                                break;

                                            case (7):
                                                m_StartingColumnNumber4_moveText = "g";
                                                break;

                                            case (8):
                                                m_StartingColumnNumber4_moveText = "h";
                                                break;

                                            default:
                                                m_StartingColumnNumber4_moveText = "Error";
                                                break;
                                        }

                                        switch (m_FinishingColumnNumber4)
                                        {
                                            case (1):
                                                m_FinishingColumnNumber4_moveText = "a";
                                                break;

                                            case (2):
                                                m_FinishingColumnNumber4_moveText = "b";
                                                break;

                                            case (3):
                                                m_FinishingColumnNumber4_moveText = "c";
                                                break;

                                            case (4):
                                                m_FinishingColumnNumber4_moveText = "d";
                                                break;

                                            case (5):
                                                m_FinishingColumnNumber4_moveText = "e";
                                                break;

                                            case (6):
                                                m_FinishingColumnNumber4_moveText = "f";
                                                break;

                                            case (7):
                                                m_FinishingColumnNumber4_moveText = "g";
                                                break;

                                            case (8):
                                                m_FinishingColumnNumber4_moveText = "h";
                                                break;

                                            default:
                                                m_FinishingColumnNumber4_moveText = "Error";
                                                break;
                                        }

                                        Movimiento4 = String.Concat(m_StartingColumnNumber4_moveText,
                                                                   m_StartingRank4.ToString(), " -> ",
                                                                   m_FinishingColumnNumber4_moveText,
                                                                   m_FinishingRank4.ToString());



                                        Analisis4Nodo_Text[cantidadNodoNivel4] = Movimiento4;

                                        Skakiera_Thinking_HY_4[(m_StartingColumnNumber4 - 1), (m_StartingRank4 - 1)] = "";
                                        Skakiera_Thinking_HY_4[(m_FinishingColumnNumber4 - 1), (m_FinishingRank4 - 1)] = MovingPiece4;


                                        temporalPuntajeMovimiento4 = contarPuntaje(Skakiera_Thinking_HY_4);


                                        analisisNodo4[cantidadNodoNivel4, 0] = temporalPuntajeMovimiento4;
                                        analisisNodo4[cantidadNodoNivel4, 1] = cantidadNodoNivel3;







                                        Skakiera_Thinking_HY_4[(m_StartingColumnNumber4 - 1), (m_StartingRank4 - 1)] = MovingPiece4;
                                        Skakiera_Thinking_HY_4[(m_FinishingColumnNumber4 - 1), (m_FinishingRank4 - 1)] = ProsorinoKommati4;

                                        cantidadNodoNivel4++;
                                        totalNodos++;




                                    }

                                }
                            }

                        }


                    }
                }

                movimientoAnalizado = movimientoAnalizado - 1;
                quienEStaAnalizado = "Human";
            }

            public static void EncontrarAtacantes(string[,] SkakieraAttackers)
            {
                String MovingPiece_Attack = "";
                int m_StartingRank_Attack = 0;
                int m_StartingColumnNumber_Attack = 0;
                int m_FinishingRank_Attack = 0;
                int m_FinishingColumnNumber_Attack = 0;


                for (int iii2 = 0; iii2 <= 7; iii2++)
                {
                    for (int jjj2 = 0; jjj2 <= 7; jjj2++)
                    {
                        if ((((SkakieraAttackers[(iii2), (jjj2)].CompareTo("White King") == 0) || (SkakieraAttackers[(iii2), (jjj2)].CompareTo("White Queen") == 0) || (SkakieraAttackers[(iii2), (jjj2)].CompareTo("White Rook") == 0) || (SkakieraAttackers[(iii2), (jjj2)].CompareTo("White Knight") == 0) || (SkakieraAttackers[(iii2), (jjj2)].CompareTo("White Bishop") == 0) || (SkakieraAttackers[(iii2), (jjj2)].CompareTo("White Pawn") == 0)) && (mColorJugsdor.CompareTo("White") == 0)) || (((SkakieraAttackers[(iii2), (jjj2)].CompareTo("Black King") == 0) || (SkakieraAttackers[(iii2), (jjj2)].CompareTo("Black Queen") == 0) || (SkakieraAttackers[(iii2), (jjj2)].CompareTo("Black Rook") == 0) || (SkakieraAttackers[(iii2), (jjj2)].CompareTo("Black Knight") == 0) || (SkakieraAttackers[(iii2), (jjj2)].CompareTo("Black Bishop") == 0) || (SkakieraAttackers[(iii2), (jjj2)].CompareTo("Black Pawn") == 0)) && (mColorJugsdor.CompareTo("Black") == 0)))
                        {

                            MovingPiece_Attack = SkakieraAttackers[(iii2), (jjj2)];
                            m_StartingColumnNumber_Attack = iii2 + 1;
                            m_StartingRank_Attack = jjj2 + 1;

                            for (int w2 = 0; w2 <= 7; w2++)
                            {
                                for (int r2 = 0; r2 <= 7; r2++)
                                {
                                    m_FinishingColumnNumber_Attack = w2 + 1;
                                    m_FinishingRank_Attack = r2 + 1;

                                    ActualJugando = "Human";
                                    m_WrongColumn = false;
                                    m_OrthotitaKinisis = ElegxosOrthotitas(Skakiera, 1, m_StartingRank_Attack, m_StartingColumnNumber_Attack, m_FinishingRank_Attack, m_FinishingColumnNumber_Attack, MovingPiece_Attack);
                                    if (m_OrthotitaKinisis == true)
                                    {
                                        m_NomimotitaKinisis = ElegxosNomimotitas(Skakiera, 1, m_StartingRank_Attack, m_StartingColumnNumber_Attack, m_FinishingRank_Attack, m_FinishingColumnNumber_Attack, MovingPiece_Attack);
                                    }

                                    ActualJugando = "HY";

                                    if ((MovingPiece_Attack.CompareTo("White Pawn") == 0) || (MovingPiece_Attack.CompareTo("Black Pawn") == 0))
                                    {
                                        if (m_FinishingColumnNumber_Attack == m_StartingColumnNumber_Attack)
                                        {
                                            m_OrthotitaKinisis = false;
                                        }
                                    }

                                    if ((m_OrthotitaKinisis == true) && (m_NomimotitaKinisis == true))
                                    {

                                        numeroAtacantes[(m_FinishingColumnNumber_Attack - 1), (m_FinishingRank_Attack - 1)] = numeroAtacantes[(m_FinishingColumnNumber_Attack - 1), (m_FinishingRank_Attack - 1)] + 1;

                                        if ((MovingPiece_Attack.CompareTo("White Rook") == 0) || (MovingPiece_Attack.CompareTo("Black Rook") == 0))
                                            valorAtacantes[(m_FinishingColumnNumber_Attack - 1), (m_FinishingRank_Attack - 1)] = valorAtacantes[(m_FinishingColumnNumber_Attack - 1), (m_FinishingRank_Attack - 1)] + 5;
                                        else if ((MovingPiece_Attack.CompareTo("White Bishop") == 0) || (MovingPiece_Attack.CompareTo("Black Bishop") == 0))
                                            valorAtacantes[(m_FinishingColumnNumber_Attack - 1), (m_FinishingRank_Attack - 1)] = valorAtacantes[(m_FinishingColumnNumber_Attack - 1), (m_FinishingRank_Attack - 1)] + 3;
                                        else if ((MovingPiece_Attack.CompareTo("White Knight") == 0) || (MovingPiece_Attack.CompareTo("Black Knight") == 0))
                                            valorAtacantes[(m_FinishingColumnNumber_Attack - 1), (m_FinishingRank_Attack - 1)] = valorAtacantes[(m_FinishingColumnNumber_Attack - 1), (m_FinishingRank_Attack - 1)] + 3;
                                        else if ((MovingPiece_Attack.CompareTo("White Queen") == 0) || (MovingPiece_Attack.CompareTo("Black Queen") == 0))
                                            valorAtacantes[(m_FinishingColumnNumber_Attack - 1), (m_FinishingRank_Attack - 1)] = valorAtacantes[(m_FinishingColumnNumber_Attack - 1), (m_FinishingRank_Attack - 1)] + 9;
                                        else if ((MovingPiece_Attack.CompareTo("White Pawn") == 0) || (MovingPiece_Attack.CompareTo("Black Pawn") == 0))
                                            valorAtacantes[(m_FinishingColumnNumber_Attack - 1), (m_FinishingRank_Attack - 1)] = valorAtacantes[(m_FinishingColumnNumber_Attack - 1), (m_FinishingRank_Attack - 1)] + 1;
                                    }
                                }
                            }
                        }
                    }
                }


            }


            public static void EncontrarDefensores(string[,] SkakieraDefenders)
            {

                String MovingPiece_Attack = "";
                int m_StartingRank_Attack = 0;
                int m_StartingColumnNumber_Attack = 0;
                int m_FinishingRank_Attack = 0;
                int m_FinishingColumnNumber_Attack = 0;


                for (int iii3 = 0; iii3 <= 7; iii3++)
                {
                    for (int jjj3 = 0; jjj3 <= 7; jjj3++)
                    {
                        if ((((SkakieraDefenders[(iii3), (jjj3)].CompareTo("White King") == 0) || (SkakieraDefenders[(iii3), (jjj3)].CompareTo("White Queen") == 0) || (SkakieraDefenders[(iii3), (jjj3)].CompareTo("White Rook") == 0) || (SkakieraDefenders[(iii3), (jjj3)].CompareTo("White Knight") == 0) || (SkakieraDefenders[(iii3), (jjj3)].CompareTo("White Bishop") == 0) || (SkakieraDefenders[(iii3), (jjj3)].CompareTo("White Pawn") == 0)) && (mColorJugsdor.CompareTo("Black") == 0)) || (((SkakieraDefenders[(iii3), (jjj3)].CompareTo("Black King") == 0) || (SkakieraDefenders[(iii3), (jjj3)].CompareTo("Black Queen") == 0) || (SkakieraDefenders[(iii3), (jjj3)].CompareTo("Black Rook") == 0) || (SkakieraDefenders[(iii3), (jjj3)].CompareTo("Black Knight") == 0) || (SkakieraDefenders[(iii3), (jjj3)].CompareTo("Black Bishop") == 0) || (SkakieraDefenders[(iii3), (jjj3)].CompareTo("Black Pawn") == 0)) && (mColorJugsdor.CompareTo("White") == 0)))
                        {
                            MovingPiece_Attack = SkakieraDefenders[(iii3), (jjj3)];
                            m_StartingColumnNumber_Attack = iii3 + 1;
                            m_StartingRank_Attack = jjj3 + 1;

                            for (int w1 = 0; w1 <= 7; w1++)
                            {
                                for (int r1 = 0; r1 <= 7; r1++)
                                {

                                    m_FinishingColumnNumber_Attack = w1 + 1;
                                    m_FinishingRank_Attack = r1 + 1;

                                    ActualJugando = "Human";
                                    m_WrongColumn = false;
                                    m_OrthotitaKinisis = ElegxosOrthotitas(SkakieraDefenders, 1, m_StartingRank_Attack, m_StartingColumnNumber_Attack, m_FinishingRank_Attack, m_FinishingColumnNumber_Attack, MovingPiece_Attack);
                                    if (m_OrthotitaKinisis == true)
                                    {
                                        m_NomimotitaKinisis = ElegxosNomimotitas(SkakieraDefenders, 1, m_StartingRank_Attack, m_StartingColumnNumber_Attack, m_FinishingRank_Attack, m_FinishingColumnNumber_Attack, MovingPiece_Attack);
                                    }

                                    ActualJugando = "HY";


                                    if ((MovingPiece_Attack.CompareTo("White Pawn") == 0) || (MovingPiece_Attack.CompareTo("Black Pawn") == 0))
                                    {
                                        if (m_FinishingColumnNumber_Attack == m_StartingColumnNumber_Attack)
                                        {
                                            m_OrthotitaKinisis = false;
                                        }
                                    }

                                    ActualJugando = "HY";
                                    if ((m_OrthotitaKinisis == true) && (m_NomimotitaKinisis == true))
                                    {
                                        numeroDefensores[(m_FinishingColumnNumber_Attack - 1), (m_FinishingRank_Attack - 1)] = numeroDefensores[(m_FinishingColumnNumber_Attack - 1), (m_FinishingRank_Attack - 1)] + 1;


                                        if ((MovingPiece_Attack.CompareTo("White Rook") == 0) || (MovingPiece_Attack.CompareTo("Black Rook") == 0))
                                            valorDefensores[(m_FinishingColumnNumber_Attack - 1), (m_FinishingRank_Attack - 1)] = valorDefensores[(m_FinishingColumnNumber_Attack - 1), (m_FinishingRank_Attack - 1)] + 5;
                                        else if ((MovingPiece_Attack.CompareTo("White Bishop") == 0) || (MovingPiece_Attack.CompareTo("Black Bishop") == 0))
                                            valorDefensores[(m_FinishingColumnNumber_Attack - 1), (m_FinishingRank_Attack - 1)] = valorDefensores[(m_FinishingColumnNumber_Attack - 1), (m_FinishingRank_Attack - 1)] + 3;
                                        else if ((MovingPiece_Attack.CompareTo("White Knight") == 0) || (MovingPiece_Attack.CompareTo("Black Knight") == 0))
                                            valorDefensores[(m_FinishingColumnNumber_Attack - 1), (m_FinishingRank_Attack - 1)] = valorDefensores[(m_FinishingColumnNumber_Attack - 1), (m_FinishingRank_Attack - 1)] + 3;
                                        else if ((MovingPiece_Attack.CompareTo("White Queen") == 0) || (MovingPiece_Attack.CompareTo("Black Queen") == 0))
                                            valorDefensores[(m_FinishingColumnNumber_Attack - 1), (m_FinishingRank_Attack - 1)] = valorDefensores[(m_FinishingColumnNumber_Attack - 1), (m_FinishingRank_Attack - 1)] + 9;
                                        else if ((MovingPiece_Attack.CompareTo("White Pawn") == 0) || (MovingPiece_Attack.CompareTo("Black Pawn") == 0))
                                            valorDefensores[(m_FinishingColumnNumber_Attack - 1), (m_FinishingRank_Attack - 1)] = valorDefensores[(m_FinishingColumnNumber_Attack - 1), (m_FinishingRank_Attack - 1)] + 1;
                                        else if ((MovingPiece_Attack.CompareTo("White King") == 0) || (MovingPiece_Attack.CompareTo("Black King") == 0))
                                            valorDefensores[(m_FinishingColumnNumber_Attack - 1), (m_FinishingRank_Attack - 1)] = valorDefensores[(m_FinishingColumnNumber_Attack - 1), (m_FinishingRank_Attack - 1)] + 15;


                                    }
                                }
                            }
                        }
                    }
                }
            }

        };



        private void button_Play_Click(object sender, EventArgs e)
        {
            try
            {

                System.IO.File.Delete("HUO_CHESS_LOG_Minimax_Thought_Process.txt");
                System.IO.File.Delete("HUO_CHESS_LOG_Minmax_Before.txt");
                System.IO.File.Delete("HUO_CHESS_LOG_Minmax_After.txt");
                System.IO.File.Delete("HUO_CHESS_LOG_Attackers_Defenders.txt");

            }

            catch
            {

            }

            try
            {
                Form1.Ajedrez_main.Starting_position();
                RedibujarSkakiera(Form1.Ajedrez_main.Skakiera);
            }

            catch
            {

            }

            try
            {
                if (Form1.Ajedrez_main.ActualJugando.CompareTo("HY") == 0)
                {
                    label2.Text = "Thinking...";
                    label3.Text = "";
                    label_variant_thought.Text = "-";
                }
            }

            catch { }

            try
            {
                Form1.Ajedrez_main.Main_Console();
            }

            catch
            {

            }

            try
            {
                RedibujarSkakiera(Form1.Ajedrez_main.Skakiera);
            }

            catch
            {

            }

            label2.Text = string.Concat("Huo Chess move: ", Ajedrez_main.siguienteLinea);
            label3.Text = string.Concat("Final positions analyzed: ", Ajedrez_main.posicionesFinales);
            label_variant_thought.Text = Ajedrez_main.Best_Variant_text;
            Application.DoEvents();
        }

        private void radioButton_White_Click(object sender, EventArgs e)
        {
            Form1.Ajedrez_main.mColorJugsdor = "White";
            Form1.Ajedrez_main.ActualJugando = "Human";
        }

        private void radioButton_Black_Click(object sender, EventArgs e)
        {
            try
            {
                Form1.Ajedrez_main.mColorJugsdor = "Black";
                Form1.Ajedrez_main.ActualJugando = "HY";
            }

            catch
            {

            }
        }

        private void Form1_Click(object sender, EventArgs e)
        {

        }

        private void ManageGameSequence()
        {

            if (vecesClickeadoJugador == 0)
            {
                Ajedrez_main.m_StartingColumn = columnaClikeada;
                Ajedrez_main.m_StartingRank = rankClicked;
                vecesClickeadoJugador++;
            }

            else if (vecesClickeadoJugador == 1)
            {
                Ajedrez_main.m_FinishingColumn = columnaClikeada;
                Ajedrez_main.m_FinishingRank = rankClicked;
                vecesClickeadoJugador++;
                Ajedrez_main.Enter_move();
                if ((Ajedrez_main.m_OrthotitaKinisis == true) && (Ajedrez_main.m_NomimotitaKinisis == true))
                    call_AI();
                else
                    vecesClickeadoJugador = 0;
            }
        }

        private void call_AI()
        {
            vecesClickeadoJugador = 0;
            RedibujarSkakiera(Form1.Ajedrez_main.Skakiera);
            label2.Text = "Thinking...";
            label3.Text = "";
            Application.DoEvents();

            Ajedrez_main.movimeinto = 0;
            Ajedrez_main.movimientoAnalizado = 0;
            Ajedrez_main.detenerAnalisis = false;
            Ajedrez_main.First_Call = true;
            Ajedrez_main.mejorMovimientoEncontrado = false;
            Ajedrez_main.quienEStaAnalizado = "HY";
            Ajedrez_main.totalNodos = 0;
            Ajedrez_main.cantidadNodoNivel0 = 0;
            Ajedrez_main.cantidadNodoNivel1 = 0;
            Ajedrez_main.cantidadNodoNivel2 = 0;
            Ajedrez_main.cantidadNodoNivel3 = 0;
            Ajedrez_main.cantidadNodoNivel4 = 0;
            Ajedrez_main.cantidadNodoNivel5 = 0;
            Ajedrez_main.cantidadNodoNivel6 = 0;

            Ajedrez_main.movimientoInteligenciaArtificial(Form1.Ajedrez_main.Skakiera);
            RedibujarSkakiera(Form1.Ajedrez_main.Skakiera);
            label2.Text = string.Concat("Huo Chess move: ", Ajedrez_main.siguienteLinea);
            label3.Text = string.Concat("Final positions analyzed: ", Ajedrez_main.posicionesFinales);
            label_variant_thought.Text = Ajedrez_main.Best_Variant_text;
        }



        private void pictureBoxD2_Click(object sender, EventArgs e)
        {
            rankClicked = 2;
            columnaClikeada = "D";
            ManageGameSequence();
        }

        private void pictureBoxD4_Click(object sender, EventArgs e)
        {
            rankClicked = 4;
            columnaClikeada = "D";
            ManageGameSequence();

        }

        private void pictureBoxA1_Click(object sender, EventArgs e)
        {
            rankClicked = 1;
            columnaClikeada = "A";
            ManageGameSequence();
        }

        private void pictureBoxA2_Click(object sender, EventArgs e)
        {
            rankClicked = 2;
            columnaClikeada = "A";
            ManageGameSequence();
        }

        private void pictureBoxA3_Click(object sender, EventArgs e)
        {
            rankClicked = 3;
            columnaClikeada = "A";
            ManageGameSequence();
        }

        private void pictureBoxA4_Click(object sender, EventArgs e)
        {
            rankClicked = 4;
            columnaClikeada = "A";
            ManageGameSequence();
        }

        private void pictureBoxA5_Click(object sender, EventArgs e)
        {
            rankClicked = 5;
            columnaClikeada = "A";
            ManageGameSequence();
        }

        private void pictureBoxA6_Click(object sender, EventArgs e)
        {
            rankClicked = 6;
            columnaClikeada = "A";
            ManageGameSequence();
        }

        private void pictureBoxA7_Click(object sender, EventArgs e)
        {
            rankClicked = 7;
            columnaClikeada = "A";
            ManageGameSequence();
        }

        private void pictureBoxA8_Click(object sender, EventArgs e)
        {
            rankClicked = 8;
            columnaClikeada = "A";
            ManageGameSequence();
        }

        private void pictureBoxB1_Click(object sender, EventArgs e)
        {
            rankClicked = 1;
            columnaClikeada = "B";
            ManageGameSequence();
        }

        private void pictureBoxB2_Click(object sender, EventArgs e)
        {
            rankClicked = 2;
            columnaClikeada = "B";
            ManageGameSequence();
        }

        private void pictureBoxB3_Click(object sender, EventArgs e)
        {
            rankClicked = 3;
            columnaClikeada = "B";
            ManageGameSequence();
        }

        private void pictureBoxB4_Click(object sender, EventArgs e)
        {
            rankClicked = 4;
            columnaClikeada = "B";
            ManageGameSequence();
        }

        private void pictureBoxB5_Click(object sender, EventArgs e)
        {
            rankClicked = 5;
            columnaClikeada = "B";
            ManageGameSequence();
        }

        private void pictureBoxB6_Click(object sender, EventArgs e)
        {
            rankClicked = 6;
            columnaClikeada = "B";
            ManageGameSequence();
        }

        private void pictureBoxB7_Click(object sender, EventArgs e)
        {
            rankClicked = 7;
            columnaClikeada = "B";
            ManageGameSequence();
        }

        private void pictureBoxB8_Click(object sender, EventArgs e)
        {
            rankClicked = 8;
            columnaClikeada = "B";
            ManageGameSequence();
        }

        private void pictureBoxC1_Click(object sender, EventArgs e)
        {
            rankClicked = 1;
            columnaClikeada = "C";
            ManageGameSequence();
        }

        private void pictureBoxC2_Click(object sender, EventArgs e)
        {
            columnaClikeada = "C";
            rankClicked = 2;
            ManageGameSequence();
        }

        private void pictureBoxC3_Click(object sender, EventArgs e)
        {
            columnaClikeada = "C";
            rankClicked = 3;
            ManageGameSequence();
        }

        private void pictureBoxC4_Click(object sender, EventArgs e)
        {
            columnaClikeada = "C";
            rankClicked = 4;
            ManageGameSequence();
        }

        private void pictureBoxC5_Click(object sender, EventArgs e)
        {
            columnaClikeada = "C";
            rankClicked = 5;
            ManageGameSequence();
        }

        private void pictureBoxC6_Click(object sender, EventArgs e)
        {
            columnaClikeada = "C";
            rankClicked = 6;
            ManageGameSequence();
        }

        private void pictureBoxC7_Click(object sender, EventArgs e)
        {
            columnaClikeada = "C";
            rankClicked = 7;
            ManageGameSequence();
        }

        private void pictureBoxC8_Click(object sender, EventArgs e)
        {
            columnaClikeada = "C";
            rankClicked = 8;
            ManageGameSequence();
        }

        private void pictureBoxD1_Click(object sender, EventArgs e)
        {
            columnaClikeada = "D";
            rankClicked = 1;
            ManageGameSequence();
        }

        private void pictureBoxD3_Click(object sender, EventArgs e)
        {
            columnaClikeada = "D";
            rankClicked = 3;
            ManageGameSequence();
        }

        private void pictureBoxD5_Click(object sender, EventArgs e)
        {
            columnaClikeada = "D";
            rankClicked = 5;
            ManageGameSequence();
        }

        private void pictureBoxD6_Click(object sender, EventArgs e)
        {
            columnaClikeada = "D";
            rankClicked = 6;
            ManageGameSequence();
        }

        private void pictureBoxD7_Click(object sender, EventArgs e)
        {
            columnaClikeada = "D";
            rankClicked = 7;
            ManageGameSequence();
        }

        private void pictureBoxD8_Click(object sender, EventArgs e)
        {
            columnaClikeada = "D";
            rankClicked = 8;
            ManageGameSequence();
        }

        private void pictureBoxE1_Click(object sender, EventArgs e)
        {
            columnaClikeada = "E";
            rankClicked = 1;
            ManageGameSequence();
        }

        private void pictureBoxE2_Click(object sender, EventArgs e)
        {
            columnaClikeada = "E";
            rankClicked = 2;
            ManageGameSequence();
        }

        private void pictureBoxE3_Click(object sender, EventArgs e)
        {
            columnaClikeada = "E";
            rankClicked = 3;
            ManageGameSequence();
        }

        private void pictureBoxE4_Click(object sender, EventArgs e)
        {
            columnaClikeada = "E";
            rankClicked = 4;
            ManageGameSequence();
        }

        private void pictureBoxE5_Click(object sender, EventArgs e)
        {
            columnaClikeada = "E";
            rankClicked = 5;
            ManageGameSequence();
        }

        private void pictureBoxE6_Click(object sender, EventArgs e)
        {
            columnaClikeada = "E";
            rankClicked = 6;
            ManageGameSequence();
        }

        private void pictureBoxE7_Click(object sender, EventArgs e)
        {
            columnaClikeada = "E";
            rankClicked = 7;
            ManageGameSequence();
        }

        private void pictureBoxE8_Click(object sender, EventArgs e)
        {
            columnaClikeada = "E";
            rankClicked = 8;
            ManageGameSequence();
        }

        private void pictureBoxF1_Click(object sender, EventArgs e)
        {
            columnaClikeada = "F";
            rankClicked = 1;
            ManageGameSequence();
        }

        private void pictureBoxF2_Click(object sender, EventArgs e)
        {
            columnaClikeada = "F";
            rankClicked = 2;
            ManageGameSequence();
        }

        private void pictureBoxF3_Click(object sender, EventArgs e)
        {
            columnaClikeada = "F";
            rankClicked = 3;
            ManageGameSequence();
        }

        private void pictureBoxF4_Click(object sender, EventArgs e)
        {
            columnaClikeada = "F";
            rankClicked = 4;
            ManageGameSequence();
        }

        private void pictureBoxF5_Click(object sender, EventArgs e)
        {
            columnaClikeada = "F";
            rankClicked = 5;
            ManageGameSequence();
        }

        private void pictureBoxF6_Click(object sender, EventArgs e)
        {
            columnaClikeada = "F";
            rankClicked = 6;
            ManageGameSequence();
        }

        private void pictureBoxF7_Click(object sender, EventArgs e)
        {
            columnaClikeada = "F";
            rankClicked = 7;
            ManageGameSequence();
        }

        private void pictureBoxF8_Click(object sender, EventArgs e)
        {
            columnaClikeada = "F";
            rankClicked = 8;
            ManageGameSequence();
        }

        private void pictureBoxG1_Click(object sender, EventArgs e)
        {
            columnaClikeada = "G";
            rankClicked = 1;
            ManageGameSequence();
        }

        private void pictureBoxG2_Click(object sender, EventArgs e)
        {
            columnaClikeada = "G";
            rankClicked = 2;
            ManageGameSequence();
        }

        private void pictureBoxG3_Click(object sender, EventArgs e)
        {
            columnaClikeada = "G";
            rankClicked = 3;
            ManageGameSequence();
        }

        private void pictureBoxG4_Click(object sender, EventArgs e)
        {
            columnaClikeada = "G";
            rankClicked = 4;
            ManageGameSequence();
        }

        private void pictureBoxG5_Click(object sender, EventArgs e)
        {
            columnaClikeada = "G";
            rankClicked = 5;
            ManageGameSequence();
        }

        private void pictureBoxG6_Click(object sender, EventArgs e)
        {
            columnaClikeada = "G";
            rankClicked = 6;
            ManageGameSequence();
        }

        private void pictureBoxG7_Click(object sender, EventArgs e)
        {
            columnaClikeada = "G";
            rankClicked = 7;
            ManageGameSequence();
        }

        private void pictureBoxG8_Click(object sender, EventArgs e)
        {
            columnaClikeada = "G";
            rankClicked = 8;
            ManageGameSequence();
        }

        private void pictureBoxH1_Click(object sender, EventArgs e)
        {
            columnaClikeada = "H";
            rankClicked = 1;
            ManageGameSequence();
        }

        private void pictureBoxH2_Click(object sender, EventArgs e)
        {
            columnaClikeada = "H";
            rankClicked = 2;
            ManageGameSequence();
        }

        private void pictureBoxH3_Click(object sender, EventArgs e)
        {
            columnaClikeada = "H";
            rankClicked = 3;
            ManageGameSequence();
        }

        private void pictureBoxH4_Click(object sender, EventArgs e)
        {
            columnaClikeada = "H";
            rankClicked = 4;
            ManageGameSequence();
        }

        private void pictureBoxH5_Click(object sender, EventArgs e)
        {
            columnaClikeada = "H";
            rankClicked = 5;
            ManageGameSequence();
        }

        private void pictureBoxH6_Click(object sender, EventArgs e)
        {
            columnaClikeada = "H";
            rankClicked = 6;
            ManageGameSequence();
        }

        private void pictureBoxH7_Click(object sender, EventArgs e)
        {
            columnaClikeada = "H";
            rankClicked = 7;
            ManageGameSequence();
        }

        private void pictureBoxH8_Click(object sender, EventArgs e)
        {
            columnaClikeada = "H";
            rankClicked = 8;
            ManageGameSequence();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            radioButton_White.Select();
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}

