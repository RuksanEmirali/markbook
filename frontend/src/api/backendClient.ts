export interface Student {
    id: number
    forename: string
    surname: string
    gender: string
    house: string
    year: number
}

export interface Students {
    students: Array<Student>
}

export async function getStudents() {
    return await fetch(`http://localhost:5006/student`, {
        method: "GET",
        headers: { "Content-Type": "application/json" }
    })
}

export async function searchStudents(
    id?: string,
    forename?: string,
    surname?: string,
    year?: number,
    house?: number,
    gender?: number
) {
    let query = `search?`
    if (id?.length !=0){
        query += `Id=${id}`
    }
    if (forename?.length !=0){
        query += `Forename=${forename}`
    }
    if (surname?.length !=0){
        query += `&Surname=${surname}`
    }
    if (year !=0){
        query += `&Year=${year}`
    }
    if (house != 0) {
        query += `&House=${house}`
    }
    if (gender !=0){
        query += `&Gender=${gender}`
    }
    // Id=${id}&Forename=${forename}&Surname=${surname}&Year=${year}&House=${house}&Gender=${gender}`
    return await fetch(`http://localhost:5006/${query}`, {
        method: "GET",
        headers: { "Content-Type": "application/json" },
        // body: JSON.stringify({
        //     Id : id,
        //     Forename : forname,
        //     Surname : surname,
        //     Year : year,
        //     House : house,
        //     Gender : gender
        // })
    })
}