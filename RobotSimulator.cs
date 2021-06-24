using System;

static class Constants
{
    public const char TurnRight = 'R';
    public const char TurnLeft = 'L';
    public const char Advance = 'A';
}

public enum Direction
{
    North,
    East,
    South,
    West
}

public class RobotSimulator
{
    public RobotSimulator(Direction direction, int x, int y)
    {
        Direction = direction;
        X = x;
        Y = y;
    }

    public Direction Direction { get; set;}

    public int X { get; set;}

    public int Y { get; set;}

    public void Move(string instructions)
    {
        for (int i = 0; i < instructions.Length; i++)
        {
            if (instructions[i] == Constants.Advance)
            {
                Advance();
            }
            else if (instructions[i] == Constants.TurnLeft)
            {
                if (((int)Direction - 1) >= 0)
                    Direction = (Direction)((int)Direction - 1);
                else
                    Direction = (Direction)Enum.GetNames(typeof(Direction)).Length - 1;
            }
            else
            {
                if (((int)Direction + 1) < Enum.GetNames(typeof(Direction)).Length)
                    Direction = (Direction)((int)Direction + 1);
                else
                    Direction = 0;
            }
        }
    }

    private void Advance()
    {
        if (Direction == Direction.North)
        {
            Y++;
        }
        else if (Direction == Direction.East)
        {
            X++;
        }
        else if (Direction == Direction.South)
        {
            Y--;
        }
        else
        {
            X--;
        }
    }
}