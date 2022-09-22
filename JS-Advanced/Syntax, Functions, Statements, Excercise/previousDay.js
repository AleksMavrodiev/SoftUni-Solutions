function previousDay(year, month, day){
    let pattern = `${year}/${month}/${day}`;
    let myDate = new Date(pattern);
    myDate.setDate(myDate.getDate() - 1);
    console.log(`${myDate.getFullYear()}-${myDate.getMonth() + 1}-${myDate.getDate()}`);
}

previousDay(2016, 10, 1);
