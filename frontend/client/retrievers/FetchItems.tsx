

import ItemInterface from "@/interfaces/ItemInterface";
const FetchItems = async () => {
    const FetchedItems  = await fetch('http://localhost:5010/ElectricalItems/GetAllElectricalItems');
    return await FetchedItems.json();
}
 
export default FetchItems;