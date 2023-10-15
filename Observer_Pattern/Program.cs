using Observer_Pattern.Observers;
using Observer_Pattern.Subjects;

WeatherStation weatherStation = new WeatherStation();

NewsAgency alphaAgency = new NewsAgency("Alpha News");
weatherStation.Attach(alphaAgency);

NewsAgency omegaAgency = new NewsAgency("Omega News");
weatherStation.Attach(omegaAgency);

weatherStation.Temparature = 28.87f;
weatherStation.Temparature = 35.34f;
weatherStation.Temparature = 42.11f;
weatherStation.Temparature = 33.33f;