fetch("https://localhost:7001/api/Directory")
.then(res=>res.json())
.then(res=>{const dirs = res})

$("#add").on("click", ()=>{
    nameDir = $("#name").val();
    fetch("https://localhost:7001/api/Directory",
    {method: "POST",
    headers: {"Content-Type": "application/json"},
    body: JSON.stringify({name: nameDir, absolutepath: "string"})}
)
.then(res => res.json())
.then(res => console.log(res))
});