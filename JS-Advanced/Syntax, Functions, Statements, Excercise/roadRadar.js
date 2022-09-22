function roadRadar(speed, zone){
    let zoneSpeed = 0;
    let difference = 0;
    switch(zone){
        case "motorway": zoneSpeed = 130; break;
        case "interstate": zoneSpeed = 90; break;
        case "city": zoneSpeed = 50; break;
        case "residential": zoneSpeed = 20; break;
    }
    difference = zoneSpeed - speed;
    let status = "";
    if(difference < 0 && difference >= -20){
        status = "speeding";
    }
    else if(difference < -20 && difference >= -40){
        status = "excessive speeding";
    }
    else if(difference < -40){
        status = "reckless driving";
    }
    if(difference >= 0){
        console.log(`Driving ${speed} km/h in a ${zoneSpeed} zone`);
    }
    else{
        console.log(`The speed is ${Math.abs(difference)} km/h faster than the allowed speed of ${zoneSpeed} - ${status}`);
    }
}

 roadRadar(40, 'city');
 roadRadar(21, 'residential');
 roadRadar(120, 'interstate');
 roadRadar(200, 'motorway');
