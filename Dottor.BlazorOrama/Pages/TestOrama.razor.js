import { create, search, insert, insertMultiple } from 'https://unpkg.com/@orama/orama@latest/dist/index.js'

export async function createDB()
{
    const movieDB = await create({
          schema: {
            title: 'string',
            director: 'string',
            opening_crawl: 'string',
            producer: 'string'
          }
    })

    return movieDB;
}

export async function addFilms(movieDB, films) {
    await insertMultiple(movieDB, films);
}

export async function searchFilms(movieDB, searchText) {
    const searchResult = await search(movieDB, {
        term: searchText,
        tolerance: 2,
    });

    return searchResult.hits.map((hit) => hit.document);
}