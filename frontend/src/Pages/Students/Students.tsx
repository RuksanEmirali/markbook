import { useEffect, useState } from "react"
import "./Students.scss"
import { getStudents, Student } from "../../api/backendClient"

function Students(): JSX.Element {
    const [Students, setStudents] = useState<Student[]>([])

    useEffect(() => {
        async function fetchStudents() {
            try {
                const response = await getStudents()
                if (!response.ok){
                    throw new Error("Network response failed")
                }
                const result = await response.json()
                setStudents(result.students)
            } catch (error) {
                console.error("Error in fetching students:", error)
            }
        }

        fetchStudents()
    })

    return (
        <li className="student-list">
        {Students.map((student) => (
           <div className="student-detail">
           Id: {student.id}
           Forename: {student.forename}
           Surname:{student.surname}
           Gender: {student.gender}
           House: {student.house}
           Year: {student.year}
           </div> 
        ))}
        </li>
    )
}

export default Students