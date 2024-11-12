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
        method: "get",
        headers: {
            "Content-Type": "application/json"
        },
    })
}