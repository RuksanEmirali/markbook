import { FormEvent, useState } from "react"

export function SearchStudents(): JSX.Element {
    const [id, setId] = useState("")
    const [forename, setForename] = useState("")
    const [surname, setSurname] = useState("")
    const [year, setYear] = useState("")
    const [house, setHouse] = useState("")
    const [gender, setGender] = useState("")

    return (
        <div>
            <h1 className="title">Search a Student</h1>
            <form>
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
                    <input
                        type="text"
                        id="year"
                        className="form-control"
                    onChange={(event) => setYear(event.target.value)}
                    />
                </div>

                <div>
                    <label>
                        House:
                    </label>
                </div>
                <div>
                    <input
                        type="text"
                        id="house"
                        className="form-control"
                    onChange={(event) => setHouse(event.target.value)}
                    />
                </div>

                <div>
                    <label>
                        Gender:
                    </label>
                </div>
                <div>
                    <input
                        type="text"
                        id="gender"
                        className="form-control"
                    onChange={(event) => setGender(event.target.value)}
                    />
                </div>
                <button type="submit">
                    Submit
                </button>
            </form>
        </div>
    )
}