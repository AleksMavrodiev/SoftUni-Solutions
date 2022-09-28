function solve(json){
    let parsed = JSON.parse(json);
    let columnNames = Object.keys(parsed[0]);
    let values = parsed.map(obj => Object.values(obj));

    let result = `<table>\n`;

    result = appendHeaders(result, columnNames);
    result =  appendValues(result, values);

    result += `</table>`
    function appendValues(result, values){
        
        for(let value of values) {
            result += `\t<tr>`;
            result += `<td>${escape(value[0])}</td><td>${escape(value[1])}</td>`;
            result += `</tr>\n`;
        }
        
        return result;
    }

    function appendHeaders(result, columnNames){
        result += `\t<tr>`;
        for(let columnName of columnNames) {
            result += `<th>${columnName}</th>`;
        }
        
        result += `</tr>\n`;
        return result;
    }
    
    function escape(value){
        return value.toString().replace(`<`, `&lt;`).replace(`>`, `&gt;`);
    }

    console.log(result);
}

solve(`[{"Name":"Stamat",
"Score":5.5},
{"Name":"Rumen",
"Score":6}]`
);