--
-- PostgreSQL database dump
--

-- Dumped from database version 16.3
-- Dumped by pg_dump version 16.3

SET statement_timeout = 0;
SET lock_timeout = 0;
SET idle_in_transaction_session_timeout = 0;
SET client_encoding = 'UTF8';
SET standard_conforming_strings = on;
SELECT pg_catalog.set_config('search_path', '', false);
SET check_function_bodies = false;
SET xmloption = content;
SET client_min_messages = warning;
SET row_security = off;

SET default_tablespace = '';

SET default_table_access_method = heap;

--
-- Name: additional_info; Type: TABLE; Schema: public; Owner: kumar
--

CREATE TABLE public.additional_info (
    form_id uuid,
    about text,
    declaration text,
    consent boolean
);


ALTER TABLE public.additional_info OWNER TO kumar;

--
-- Name: address; Type: TABLE; Schema: public; Owner: kumar
--

CREATE TABLE public.address (
    form_id uuid,
    house_no character varying(20),
    street character varying(255),
    city character varying(100),
    state character varying(100),
    zip_code character varying(15),
    country character varying(100)
);


ALTER TABLE public.address OWNER TO kumar;

--
-- Name: father_info; Type: TABLE; Schema: public; Owner: kumar
--

CREATE TABLE public.father_info (
    form_id uuid,
    f_name character varying(255),
    m_name character varying(255),
    l_name character varying(255),
    mobile character varying(20),
    mail character varying(255),
    occupation character varying(255)
);


ALTER TABLE public.father_info OWNER TO kumar;

--
-- Name: mother_info; Type: TABLE; Schema: public; Owner: kumar
--

CREATE TABLE public.mother_info (
    form_id uuid,
    f_name character varying(255),
    m_name character varying(255),
    l_name character varying(255),
    mobile character varying(20),
    mail character varying(255),
    occupation character varying(255)
);


ALTER TABLE public.mother_info OWNER TO kumar;

--
-- Name: personal_info; Type: TABLE; Schema: public; Owner: kumar
--

CREATE TABLE public.personal_info (
    form_id uuid NOT NULL,
    f_name character varying(255),
    m_name character varying(255),
    l_name character varying(255),
    mobile character varying(20),
    mail character varying(255),
    dob date,
    gender character varying(10)
);


ALTER TABLE public.personal_info OWNER TO kumar;

--
-- Data for Name: additional_info; Type: TABLE DATA; Schema: public; Owner: kumar
--

COPY public.additional_info (form_id, about, declaration, consent) FROM stdin;
12419c08-a173-41b0-939b-ae2292a2924f	asdf	true	t
\.


--
-- Data for Name: address; Type: TABLE DATA; Schema: public; Owner: kumar
--

COPY public.address (form_id, house_no, street, city, state, zip_code, country) FROM stdin;
12419c08-a173-41b0-939b-ae2292a2924f	as	asdf	asdfas	asd	asd	India
\.


--
-- Data for Name: father_info; Type: TABLE DATA; Schema: public; Owner: kumar
--

COPY public.father_info (form_id, f_name, m_name, l_name, mobile, mail, occupation) FROM stdin;
12419c08-a173-41b0-939b-ae2292a2924f	asdf		asdf	+91 7982268819	asdf@gmail.com	asdfasd
\.


--
-- Data for Name: mother_info; Type: TABLE DATA; Schema: public; Owner: kumar
--

COPY public.mother_info (form_id, f_name, m_name, l_name, mobile, mail, occupation) FROM stdin;
12419c08-a173-41b0-939b-ae2292a2924f	asd		asdf	+91 7982268819	asdf@gmail.com	asdf
\.


--
-- Data for Name: personal_info; Type: TABLE DATA; Schema: public; Owner: kumar
--

COPY public.personal_info (form_id, f_name, m_name, l_name, mobile, mail, dob, gender) FROM stdin;
12419c08-a173-41b0-939b-ae2292a2924f	chandan		kumar	+91 7982268819	kumarnchandan05@gmail.com	2024-07-03	Male
\.


--
-- Name: personal_info personal_info_pkey; Type: CONSTRAINT; Schema: public; Owner: kumar
--

ALTER TABLE ONLY public.personal_info
    ADD CONSTRAINT personal_info_pkey PRIMARY KEY (form_id);


--
-- Name: additional_info additional_info_form_id_fkey; Type: FK CONSTRAINT; Schema: public; Owner: kumar
--

ALTER TABLE ONLY public.additional_info
    ADD CONSTRAINT additional_info_form_id_fkey FOREIGN KEY (form_id) REFERENCES public.personal_info(form_id);


--
-- Name: address address_form_id_fkey; Type: FK CONSTRAINT; Schema: public; Owner: kumar
--

ALTER TABLE ONLY public.address
    ADD CONSTRAINT address_form_id_fkey FOREIGN KEY (form_id) REFERENCES public.personal_info(form_id);


--
-- Name: father_info father_info_form_id_fkey; Type: FK CONSTRAINT; Schema: public; Owner: kumar
--

ALTER TABLE ONLY public.father_info
    ADD CONSTRAINT father_info_form_id_fkey FOREIGN KEY (form_id) REFERENCES public.personal_info(form_id);


--
-- Name: mother_info mother_info_form_id_fkey; Type: FK CONSTRAINT; Schema: public; Owner: kumar
--

ALTER TABLE ONLY public.mother_info
    ADD CONSTRAINT mother_info_form_id_fkey FOREIGN KEY (form_id) REFERENCES public.personal_info(form_id);


--
-- PostgreSQL database dump complete
--

