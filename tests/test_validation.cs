//Note: The examples below use Python and pytest. If you are building a Node.js, a C#, or any other language backend, you should adapt these concepts using Jest/Mocha, MSTest, etc.
//look those up ^
void IsValidTarget(x, y)
{
 if (x < 0 || x > 100 || y < 0 || y > 100)
 {
   return false;
 }
 else
  {
    return true;
  }
}

void TestValues()
{
  int goodX = 50;
  int goodY = 50;
  int badX = 150;
  int badY = -10;
}
