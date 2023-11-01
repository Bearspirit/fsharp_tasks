// 23.4.1
let (.+.) x y =
    let (xg, xs, xc) = x
    let (yg, ys, yc) = y
    norm_money(xg + yg, xs + ys, xc + yc)

let (.-.) x y =
    let (xg, xs, xc) = x
    let (yg, ys, yc) = y
    norm_money(xg - yg, xs - ys, xc - yc)

// 23.4.2
let (.+) x y =
    let (xr, xi) = x
    let (yr, yi) = y
    (xr + yr, xi + yi)

let (.-) x y =
    let (yr, yi) = y
    x .+ (-yr, -yi)

let (.*) x y =
    let (xr, xi) = x
    let (yr, yi) = y
    (xr * yr - xi * yi, xr * yi + xi * yr)

let (./) x y =
    let (yr, yi) = y
    let y2 = yr * yr + yi * yi
    x .* (yr / y2, -yi / y2)