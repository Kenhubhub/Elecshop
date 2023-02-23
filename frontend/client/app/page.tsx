import Image from 'next/image'
import { Inter } from '@next/font/google'
import styles from './page.module.css'
import Table from '@/components/Table'
import ItemInterface from '@/interfaces/ItemInterface'
import { ReactPropTypes } from 'react'
import FetchItems from '@/retrievers/FetchItems'
const inter = Inter({ subsets: ['latin'] })

export default async function Home() {
  const Items:ItemInterface[] = await FetchItems();
  return (
    <main className={styles.main}>
      <Table Items = {Items}></Table>
    </main>
  )
}






