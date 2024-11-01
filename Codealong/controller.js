
function addBike() {
    let newBike = model.input.newBike;
    let myBike = {
      id: addNewId(),
      brand: newBike.brand,
      gears: newBike.gears,
      state: newBike.state,
      isAvilable: newBike.isAvilable,
      description: newBike.description, 
    };
    model.data.bikes.push(myBike);
    newBike.id = "";
    newBike.brand = "";
    newBike.gears = "";
    newBike.state = "";
    newBike.description = "";
    console.log(model.data.bikes)
    updateView();
  }
  
function addNewId(){
    let newId = Math.floor(Math.random()*9999)
    for(let i = 0; i < model.data.bikes.length; i++){
      
      if(newId === model.data.bikes[i].id){
          addNewId();
      }
  
  
    }
    return newId;
  }
  