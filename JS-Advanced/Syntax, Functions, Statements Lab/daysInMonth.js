function GetDaysInMonth(monthNum, yearNum){
    const getDays = (year, month) => {
        return new Date(year, month, 0).getDate();
    };
    let days = getDays(yearNum, monthNum);
    console.log(days);
}

GetDaysInMonth(1, 2012);