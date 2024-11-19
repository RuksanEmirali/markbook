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
    id: string,
    forname: string,
    surname: string,
    year: string,
    house: string,
    gender: string
) {
    return await fetch(`http://localhost:5006/search`, {
        method: "GET",
        headers: { "Content-Type": "application/json" },
        body: JSON.stringify({
            id,
            forname,
            surname,
            year,
            house,
            gender
        })
    })
}