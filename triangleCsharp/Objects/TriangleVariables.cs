namespace Triangle.Objects
{
  public class TriangleVariables
  {
    public int _side1;
    public int _side2;
    public int _side3;

    public int Get_side1()
        {
          return _side1;
        }

    public void Set_side1(int newLength)
    {
      _side1 = newLength;
    }

    public int Get_side2()
        {
          return _side2;
        }

    public void Set_side2(int newLength)
    {
      _side2 = newLength;
    }
    public int Get_side3()
        {
          return _side3;
        }

    public void Set_side3(int newLength)
    {
      _side3 = newLength;
    }

    public string TriangleType()
    {
      if(_side1+_side2 <= _side3 || _side2 + _side3 <= _side1 || _side1 + _side3 <= _side2)
      {
        return "this is clearly not a triangle";
      }
      else if(_side1 == _side2 && _side2 == _side3)
      {
        return "Equilateral";
      }
      else if(_side1 != _side2 && _side2 != _side3 && _side1!=_side3)
      {
        return "Scalene";
      }
      else
      {
        return "Isosceles";
      }
    }
  }

}
