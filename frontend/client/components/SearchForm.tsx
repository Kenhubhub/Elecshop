"use client"
import ItemInterface from "@/interfaces/ItemInterface";
import { FormEvent, useState } from "react";
import Card from "./Card";

import Form from "./Form"
const SearchForm = () => {
    const [Items,setItems] = useState<ItemInterface[]>([]);
    return (
        <div>

            <Form setItems={setItems}/>
            <div className="card-container">

                {
                    Items.map(Item =>(
                        <Card Item={Item}/>
                    ))
                    
                }
            </div>
        </div>

    );
}
 
export default SearchForm;