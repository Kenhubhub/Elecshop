"use client"

import ItemInterface from "@/interfaces/ItemInterface";
import { FC, FormEvent, useState } from "react";

import SearchForm from "./SearchForm";

const GetTypeItem = async ( e:FormEvent<HTMLFormElement>)=>{
    e.preventDefault();
    const type = e.currentTarget.type.value;
    
    const TypeItems =await  (await fetch(`http://localhost:5010/ElectricalItemType/GetAllElectricalItems/${type}`)).json();
    return TypeItems;
}
type PropType = {
    setItems: React.Dispatch<React.SetStateAction<ItemInterface[]>>;
}
const Form : FC<PropType> = ({setItems}) => {
    
    return(
    <form onSubmit={async e => setItems(await GetTypeItem(e))} action="">
        <input type="text" name="type" placeholder="Enter type of appliance" />
        <button type="submit">Search</button>
    </form>
    )   
}
 
export default Form;
