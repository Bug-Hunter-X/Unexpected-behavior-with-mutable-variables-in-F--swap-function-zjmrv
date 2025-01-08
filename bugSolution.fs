let x = ref 1
let y = ref 2
let z = ref 3

let swap x y =
    let temp = !x
    x := !y
    y := temp

swap x y
printf "%d %d %d" !x !y !z