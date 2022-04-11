using System;
using System.Collections.Generic;
using System.Linq;

namespace Chess
{
    public class ChessBoard
    {
        private int[] Board {get; set;} = new int[8];

        public bool IsSafe()
        {
            //No two queens can be on the same row 
            var countZeroes = Board.Count(n => n == 0);
            var countDistinct = Board.Distinct().Count();
            //The ternary operation is saying if countZeroes is greater than one then return countZeroes-1, else return 0
            if (Board.Length != countDistinct + (countZeroes > 1 ? countZeroes-1 : 0)) 
            {
                return false;
            }

            //No two queens can be on the same diagonal
            for (int i = 1; i <= 8; i++)
            {
                for (int j = i + 1; j <= 8; j++)
                {
                    if (Board[i-1] != 0 && Board[j-1] != 0)
                    {
                        var dX = Math.Abs(i-j); //delta or difference in x 
                        var dY = Math.Abs(Board[i-1] - Board[j-1]); //delta or difference in y

                        if(dX==dY) //If they are equal, then they are diagonal and this check fails 
                        {
                            return false;
                        }
                    }
                }
            }

            return true;
        }

        public static bool PlaceQueens(Chessboard board = null, int column = 0)
        {
            board = board ?? new ChessBoard();

            for(int row = 1; row <= 8; row++)
            {
                board.Board[column] = row;

                if(board.IsSafe())
                {
                    if(column ==7)
                    {
                        return true; //Success
                    }
                    else
                    {
                        var newBoard = new ChessBoard(board);
                        if(PlaceQueens(newBoard, column+1))
                        {
                            return true;
                        }
                        else 
                        {
                            continue;
                        }
                    }
                }
            }
            return false;
        }

        public static bool PlaceQueens(List<ChessBoard> solutions, ChessBoard board = null, int column = 0)
        {
            board = board ?? new ChessBoard();
            solutions = solutions ?? new List<Chessboard>(92);

            for(int row = 1; row <= 8; row++)
            {
                board.Board[column] = row;

                if(board.IsSafe())
                {
                    if(column ==7)
                    {
                        solutions.Add(new Chessboard(board));
                        return true; //Success
                    }
                    else
                    {
                        var newBoard = new ChessBoard(board);
                        if(PlaceQueens(solutions, newBoard, column+1))
                        {
                            continue;
                        }
                        else 
                        {
                            continue;
                        }
                    }
                }
            }
            return false;
        }

        #region Constructors
        public ChessBoard()
        {
        }
        public ChessBoard(ChessBoard b) : this(b.Board.Clone() as int[])
        {
        }
        private ChessBoard(int[] board)
        {
            if (board.Length != 8)
                throw new ArgumentOutOfRangeException(nameof(board), board, "Eight values are required, one for each of the eight columns.");

            if (board.Any(n => n < 0 && n > 8))
                throw new ArgumentOutOfRangeException(nameof(board), board, "Valid board positions range from 1 to 8, and zero is accepted to indicate an empty column.");

            this.Board = board;
        }
        //This one looks a bit odd but what we're doing is converting this from ASCII to integer values
        //because we're receiving the data as a string
        // To do so, we need to subtract 48 because 48 in ASCII is 0, 49 is 1, 50 is 2, and so on
        public ChessBoard(string board) : this(board.Select(c => c - 48).ToArray())
        {
        }
        #endregion

        public override string ToString() => new string(this.Board.Select(n => (char)(n + 48)).ToArray());

        #region All 92 Solutions for 'Eight Queens'
        public static readonly string[] Solutions = {
                "15863724", "16837425", "17468253", "17582463", "24683175", "25713864",
                "25741863", "26174835", "26831475", "27368514", "27581463", "28613574",
                "31758246", "35281746", "35286471", "35714286", "35841726", "36258174",
                "36271485", "36275184", "36418572", "36428571", "36814752", "36815724",
                "36824175", "37285146", "37286415", "38471625", "41582736", "41586372",
                "42586137", "42736815", "42736851", "42751863", "42857136", "42861357",
                "46152837", "46827135", "46831752", "47185263", "47382516", "47526138",
                "47531682", "48136275", "48157263", "48531726", "51468273", "51842736",
                "51863724", "52468317", "52473861", "52617483", "52814736", "53168247",
                "53172864", "53847162", "57138642", "57142863", "57248136", "57263148",
                "57263184", "57413862", "58413627", "58417263", "61528374", "62713584",
                "62714853", "63175824", "63184275", "63185247", "63571428", "63581427",
                "63724815", "63728514", "63741825", "64158273", "64285713", "64713528",
                "64718253", "68241753", "71386425", "72418536", "72631485", "73168524",
                "73825164", "74258136", "74286135", "75316824", "82417536", "82531746",
                "83162574", "84136275"
            };
        #endregion
    }
}
