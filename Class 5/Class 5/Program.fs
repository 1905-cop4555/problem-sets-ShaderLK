type Person = {Name:string; Age:int}

let p = {Age = 15;Name = "David"}

printfn "%A" p.Age

type Shape = 
    | Rectangle of width : float * length : float
    | Circle of radius : float
    | Prism of width : float * float * height : float

let rec1 =  Rectangle(length = 1.3, width = 10.0)
let circ = Circle(1.0)
let prism = Prism(5.0, 2.0, height = 3.0)

type color =  Red | Green | Blue

type 'a Shape = 
    | Rectangle of width : 'a *length : 'a
    | Circle of radius : 'a
    | Prism of width : 'a * 'a * height : 'a

let x = 3 in let f y = x + y    
             let x = 6
             f x