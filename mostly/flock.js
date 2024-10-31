// class Flock {
//     constructor(n) {
//         this.seagulls = n;
        
//     }
//     cojoin(other) {
//         this.seagulls += other.seagulls;
//         return this;
//     }
//     breed(other) {
//         this.seagulls = this.seagulls * other.seagulls;
//         return this;
//     }
// }

// const FlockA = new Flock(4);
// const FlockB = new Flock(2);
// const FlockC = new Flock(0);
// const result = FlockA
//     .cojoin(FlockC)
//     .breed(FlockB)
//     .cojoin(FlockA.breed(FlockB))
//     .seagulls;

// const cojoin = (flockX, flockY) => flockX + flockY;
// const breed = (flockX, flockY) => flockX * flockY;

const FlockA = 4;
const FlockB = 2;
const FlockC = 0;
// const result = cojoin(breed(FlockB, cojoin(FlockA, FlockC)), breed(FlockA, FlockB))

const add = (x, y) => x + y;
const multiply = (x, y) => x * y;

const result = add(multiply(FlockB, add(FlockA, FlockC)), multiply(FlockA, FlockB));

console.log(result);
