import { FormEvent, useState } from "react"
import { searchStudents, Student } from "../../api/backendClient"

export function SearchStudents(): JSX.Element {
    const [id, setId] = useState("")
    const [forename, setForename] = useState("")
    const [surname, setSurname] = useState("")
    const [year, setYear] = useState(-1)
    const [house, setHouse] = useState(-1)
    const [gender, setGender] = useState(-1)
    const [studentList, setStudentList] = useState<Student[]>([])

    async function search(event: FormEvent) {
        event.preventDefault()

        try {
            const response = await searchStudents(
                id,
                forename,
                surname,
                year,
                gender,
                house
            )

            if (!response.ok) {
                throw new Error("Error searching student")
            } else {
                const result = await response.json();
                setStudentList(result.students)
            }
        } catch (err) {
            console.error("Error searching student")
        }
    }

    return (
        <div>
            <h1 className="title">Search a Student</h1>
            <form className="search students" method="get" onSubmit={search}>
                <div>
                    <label>
                        Id:
                    </label>
                </div>
                <div>
                    <input
                        type="text"
                        id="id"
                        className="form-control"
                        onChange={(event) => setId(event.target.value)}
                    />
                </div>

                <div>
                    <label>
                        Forname:
                    </label>
                </div>
                <div>
                    <input
                        type="text"
                        id="forename"
                        className="form-control"
                        onChange={(event) => setForename(event.target.value)}
                    />
                </div>

                <div>
                    <label>
                        Surname:
                    </label>
                </div>
                <div>
                    <input
                        type="text"
                        id="surname"
                        className="form-control"
                        onChange={(event) => setSurname(event.target.value)}
                    />
                </div>

                <div>
                    <label>
                        Year:
                    </label>
                </div>
                <div>
                    <select
                    id="year"
                    className="form-control"
                    onChange={(event)=> setYear(event.target.selectedIndex)}
                    >
                      <option>Fourth Form</option>
                      <option>Remove</option>
                      <option>Fifth Form</option>
                      <option>Lower Sixth</option>
                      <option>Upper Sixth</option>
                    </select>
                </div>

                <div>
                    <label>
                        House:
                    </label>
                </div>
                <div>
                <select
                    id="house"
                    className="form-control"
                    onChange={(event)=> setHouse(event.target.selectedIndex)}
                    >
                      <option>Attkinson</option>
                      <option>Cedars</option>
                      <option>Collinson</option>
                      <option>School</option>
                    </select>
                </div>

                <div>
                    <label>
                        Gender:
                    </label>
                </div>
                <div>
                <select
                    id="gender"
                    className="form-control"
                    onChange={(event)=> setGender(event.target.selectedIndex)}
                    >
                      <option>Male</option>
                      <option>Female</option>
                      <option>Non-Binary</option>
                    </select>
                </div>
                <button type="submit">
                    Submit
                </button>
            </form>
            <li className="student-list">
                {studentList.map((student) => (
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
        </div>
    )
}