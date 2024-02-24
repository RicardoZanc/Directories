$("#add").on("click", ()=>{
    nameDir = $("#name").val();
    fetch("https://localhost:7001/api/Directory",
    {method: "POST",
    headers: {"Content-Type": "application/json"},
    body: JSON.stringify({name: nameDir})}
)
.then(res => res.json())
.then(res => console.log(res))
});