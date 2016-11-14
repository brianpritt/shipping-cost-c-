namespace ParcelPage.Objects
{
  public class Parcel
  {
    private int _height;
    private int _weight;
    private int _width;
    private int _volume;
    private int _costToShip;

    public Parcel(int parcelHeight, int parcelWeight, int parcelWidth)
    {
       _height = parcelHeight;
       _weight = parcelWeight;
      _width = parcelWidth;
    }

    public void SetHeight(int NewHeight)
    {
      _height = NewHeight;
    }
    public int GetHeight()
    {
      return _height;
    }

    public void SetWidth(int NewWidth)
    {
      _width = NewWidth;
    }
    public int GetWidth()
    {
      return _width;
    }

    public void SetWeight(int NewWeight)
    {
      _weight = NewWeight;
    }
    public int GetWeight()
    {
      return _weight;
    }

    public void SetVolume()
    {
      _volume = _width * _height;
    }
    public int GetVolume()
    {
      return _volume;
    }

    public void SetCostToShip()
    {
      _costToShip = _volume * _width;
    }

    public int GetCostToShip()
    {
      return _costToShip;
    }
  }
}
