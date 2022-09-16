function dayOfWeek(day){
    let value = 0
    switch(day){
        case'Monday': value = 1; break;
        case 'Tuesday': value = 2; break;
        case 'Wednesday': value = 3; break;
        case 'Thursday': value = 4; break;
        case 'Friday': value = 5; break;
        case 'Saturday': value = 6; break;
        case 'Sunday': value = 7; break;
        default: value = 'error'; break;
    }
    console.log(value);
}

dayOfWeek('Friday');
dayOfWeek('Maika ti');