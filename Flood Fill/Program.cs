using System;

namespace Flood_Fill
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Hello World!");
      int[][] image = new int[3][] { new int[] { 1, 1, 1 }, new int[] { 1, 1, 0 }, new int[] { 1, 0, 1 } };

      // I/P - 

      // [1, 1, 1]
      // [1, 1, 0]
      // [1, 0, 1]
      // O/P -

      // [2,2,2]
      // [2,2,0]
      // [2,0,1]
      Program p = new Program();
      p.FloodFill(image, 1, 1, 2);
    }

    public int[][] FloodFill(int[][] image, int sr, int sc, int newColor)
    {
      int oldColor = image[sr][sc];
      if (oldColor == newColor) return image;
      Fill(image, sr, sc, oldColor, newColor);
      return image;
    }

    void Fill(int[][] image, int sr, int sc, int oldColor, int newColor)
    {
      // add boundary check
      if (sr < 0 || sc < 0 || sr >= image.Length || sc >= image[0].Length || image[sr][sc] != oldColor)
      {
        return;
      }

      image[sr][sc] = newColor;
      Fill(image, sr + 1, sc, oldColor, newColor);
      Fill(image, sr - 1, sc, oldColor, newColor);
      Fill(image, sr, sc + 1, oldColor, newColor);
      Fill(image, sr, sc - 1, oldColor, newColor);
    }
  }
}
