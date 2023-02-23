import ItemInterface from "@/interfaces/ItemInterface";
interface Props{
    Item: ItemInterface;
}
const Card : React.FC<Props> = ({Item}) => {
    return ( 
        <div className="card">
            <h3> {Item.name}</h3>
            <p>{Item.description}</p>
            <p>£{Item.price}</p>
            <img src={Item.imageUrl} alt="" />
        </div>
    );
}
 
export default Card;