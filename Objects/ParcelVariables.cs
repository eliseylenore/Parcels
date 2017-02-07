namespace Parcels.Objects
{
  public class ParcelVariables
  {
    private int _width;
    private int _length;
    private int _height;

    private int _weight;

    public int GetWidth()
    {
      return _width;
    }

    public void SetWidth(int newWidth)
    {
      _width = newWidth;
    }

    public int GetLength()
    {
      return _length;
    }

    public void SetLength(int newLength)
    {
      _length = newLength;
    }

    public int GetHeight()
    {
      return _height;
    }

    public void SetHeight(int newHeight)
    {
      _height = newHeight;
    }

    public int GetWeight()
    {
      return _weight;
    }

    public void SetWeight(int newWeight)
    {
      _weight = newWeight;
    }

    public int CalculateVolume()
    {
      return _width * _length * _height;
    }

    public int CalculatePrice()
    {
      int price = 2;
      if (CalculateVolume() > 3) {
        price += 5;
      }
      return price;
    }

  }
}
