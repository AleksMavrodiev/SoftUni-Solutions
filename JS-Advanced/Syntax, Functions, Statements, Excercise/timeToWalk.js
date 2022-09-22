function timeToWalk(steps, lengthInMeters, speed){
    let metersPerSecond = speed / 3.6;
    let distance = steps * lengthInMeters;
    let restMinutes = Math.floor(distance / 500);
    let timeSeconds = distance / metersPerSecond;
    timeSeconds += restMinutes * 60;
    let hours = Math.floor(timeSeconds / 3600);
    let mins = Math.floor(timeSeconds / 60);
    let seconds = Math.round(timeSeconds % 60);
    let hoursFormat = hours < 10 ? `0${hours}` : `${hours}`;
    let minutesFormat = mins < 10 ? `0${mins}` : `${mins}`;
    let secondsFormat = seconds < 10 ? `0${seconds}` : `${seconds}`;
    console.log(`${hoursFormat}:${minutesFormat}:${secondsFormat}`);
}

timeToWalk(4000, 0.60, 5);
timeToWalk(2564, 0.70, 5.5);
