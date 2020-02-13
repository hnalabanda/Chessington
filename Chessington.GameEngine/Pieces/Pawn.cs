﻿﻿using System;
 using System.Collections.Generic;
using System.Linq;

namespace Chessington.GameEngine.Pieces
{
    public class Pawn : Piece
    {
        public Pawn(Player player) 
            : base(player) { }

        public override IEnumerable<Square> GetAvailableMoves(Board board)
        {
            Square pawnPosition = board.FindPiece(this);
            IEnumerable<Square> sq=Enumerable.Empty<Square>();
            if (this.Player == Player.Black)
            {
                if (pawnPosition.Row == 1)
                {
                    Square plusOneBlackPosition = new Square(pawnPosition.Row + 1, pawnPosition.Col);
                    Square plusTwoBlackPosition = new Square(pawnPosition.Row + 2, pawnPosition.Col);

                    sq= new Square[]{plusOneBlackPosition, plusTwoBlackPosition};
                }
                else{
                    
                    Square plusOneBlackPosition = new Square(pawnPosition.Row + 1, pawnPosition.Col);
                    sq= new Square[]{plusOneBlackPosition};
                }
            }
            else if (this.Player == Player.White)
            {
                if (pawnPosition.Row == 7)
                {
                    Square plusOneBlackPosition = new Square(pawnPosition.Row - 1, pawnPosition.Col);
                    Square plusTwoBlackPosition = new Square(pawnPosition.Row - 2, pawnPosition.Col);

                    sq= new Square[]{plusOneBlackPosition, plusTwoBlackPosition};
                }
                else{
                    
                    Square plusOneBlackPosition = new Square(pawnPosition.Row - 1, pawnPosition.Col);
                    sq= new Square[]{plusOneBlackPosition};
                }
            }

            return sq;
           // return Enumerable.Empty<Square>();
        }
    }
}