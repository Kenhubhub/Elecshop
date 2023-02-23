"use client"
import ItemInterface from "@/interfaces/ItemInterface";
import FetchItems from "@/retrievers/FetchItems";
import { PromiseProvider } from "mongoose";
import { useState,useEffect } from "react";
import useSWR from "swr"
interface Props{
    Items: ItemInterface[]
}

  
const Table: React.FC<Props> = ({Items}) => {
    const [selectedRow, setSelectedRow] = useState<ItemInterface>();
  
  
    function handleRowClick(row: ItemInterface) {
      setSelectedRow(row)
    }
    return (
        <table>
          <thead>
            <tr>
              <th>Name</th>
              <th>ID</th>
              <th>Type</th>
              <th>Description</th>
              <th>Price</th>
            </tr>
          </thead>
          <tbody>
            {Items.map(Item => (
              <tr key={Item.id} onClick={() => handleRowClick(Item)}>
                <td>{Item.name}</td>
                <td>{Item.id}</td>
                <td>{Item.type}</td>
                <td>{Item.description}</td>
                <td>£{Item.price}</td>
              </tr>
            ))}
          </tbody>
          <tfoot>
            <tr>
              <td colSpan={5} >{selectedRow ? (
                <div>
                  <div>
                    <img className="ItemImages" src={selectedRow.imageUrl} alt="" />
                  </div>
                  {`Selected: ${selectedRow.name}`}
                </div>
                ) : 'No row selected'}</td>
            </tr>
          </tfoot>
        </table>
      );
}
export default Table;