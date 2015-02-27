namespace Aklefdal.Holidays.HttpApi

open System

module Workdays =
    let IsDayOff country date =
        Dates.IsSunday date || Dates.IsSaturday date || Holidays.IsHoliday country date

    let IsWorkDay country date =
        !(IsDayOff country date)

    let rec PreviousWorkday country (date:DateTime) =
        let previousDay = date.AddDays(-1.0)
        if IsWorkDay country previousDay then previousDay
        else PreviousWorkday country previousDay
