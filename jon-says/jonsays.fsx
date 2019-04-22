let jonsays =
    "Jon Says I love newfies but everyday at "

let timeNow = System.DateTime.Now.ToLongTimeString()

let thebathroom = 
    " they need to use the restroom"

let newfies = jonsays + timeNow + thebathroom

printfn "%s" newfies 
