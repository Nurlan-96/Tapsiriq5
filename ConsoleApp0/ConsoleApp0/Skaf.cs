int QapiA = 3;
int QapiB = 7;
int QapiC = 10;

int SkafA  = 2;
int SkafB =  8;
int SkafC = 10;

// A=en B=uzunluq C=hundurluk

if ((QapiC >= SkafC && QapiB >= SkafB) || (QapiC >= SkafC && QapiB >= SkafA) || (QapiB >= SkafA && QapiC >= SkafB) || (QapiB >= SkafC && QapiC >= QapiA) || (QapiB >= SkafC && QapiC >= SkafB) || (QapiB >= SkafC && QapiC >= SkafA))
{
    Console.WriteLine("Kecir");
}

else
{
    Console.WriteLine("Kecmir");
}