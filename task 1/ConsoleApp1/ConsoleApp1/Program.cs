

float hour, minute;
Console.WriteLine("Enter Hours (12 hour format)");
hour = Int16.Parse(Console.ReadLine());
Console.WriteLine("Enter Minutes");
minute = Int16.Parse(Console.ReadLine());

float singleHourDeg, singleMinuteDeg;
singleHourDeg = 360 / 12; //Finding degrees per hour
singleMinuteDeg = 360 / 60; //Finding degrees per minute

//Calculating hour arrow
float hourDeg = hour * singleHourDeg;

//Calculating minute arrow

float minuteDeg = minute * singleMinuteDeg;

//Since hour arrow can move between due to minute arrow moving then we have to add some adjustment
float test = (float)(minute / 60) * singleHourDeg;
float hourDegAdjust = hourDeg + (minute / 60) * singleHourDeg;

float answer = hourDegAdjust - minuteDeg;

Console.WriteLine("Answer is " + Math.Abs(answer));


