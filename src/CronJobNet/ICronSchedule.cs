using System;

namespace CronJobNet;

public interface ICronSchedule
{
    bool IsValid(string expression);
    bool IsTime(DateTime dateTime);
}

